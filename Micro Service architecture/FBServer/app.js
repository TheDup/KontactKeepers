const PAGE_ACCESS_TOKEN = "EAAFa9EpgZAdIBAPZAOxwmopn8gBdvU7EwQJJ6FyLgDP1asd0NCQzkHZBEozlJORiEZAt1DutjcI0MUUo9nnaqGZB69jXFxJ66XesU7sccpqsVrEPovOtkBls12rb7p2VeiCoCzJG7rZCXCEyPVDGoUSf0chwRFwCxTWkJ1bCwpPKBWt9dJ5xN7";
const request = require('request');
let express = require('express');
var moment = require('moment')
let bodyParser = require('body-parser');
const { DateTime } = require('mssql/msnodesqlv8');
const app = express().use(bodyParser.json());
app.listen(process.env.PORT || 1337, () => console.log('webhook is listening'))


app.post('/webhook', (req, res) => {
    let body = req.body;
    if (body.object === 'page') {
        body.entry.forEach(function (entry) {
            let sender = entry.messaging[0].sender.id;
            let webhook_event = entry.messaging[0];
            if (webhook_event.message) {
                handleMessage(sender, webhook_event.message);
            } else if (webhook_event.postback) {
                handlePostback(sender, webhook_event.postback);
            }

            const sql = require('mssql/msnodesqlv8')
            const pool = new sql.ConnectionPool({
                database: 'Kontactkeeper',
                server: 'localhost',
                driver: 'msnodesqlv8',
                options: {
                    trustedConnection: true
                }
            })
            pool.connect().then(() => {
                pool.query(`delete from tblFBUser where FBID = ${sender}`, (err, result) => {
                    if (err) throw err;
                    console.log(result);
                })

                var dtnow = moment().format('YYYY-MM-DD hh:mm:ss')
                console.log(dtnow);
                pool.query(`insert into tblFBUser (FBID, FBName, LastSeen) values ('${sender}', 'null', '${dtnow}')`, (err, result) => {
                    if (err) throw err;
                    console.log(result);
                })
            })
        });
        console.log("received");
        res.status(200).send('EVENT_RECEIVED');
    } else {
        res.sendStatus(404);
    }
});

app.get('/webhook', (req, res) => {
    let VERIFY_TOKEN = "RunBushiriRun";
    let mode = req.query['hub.mode'];
    let token = req.query['hub.verify_token'];
    let challenge = req.query['hub.challenge'];

    if (mode && token) {
        if (mode === 'subscribe' && token === VERIFY_TOKEN) {
            console.log('WEBHOOK_VERIFIED');
            res.status(200).send(challenge);
        } else {
            res.sendStatus(403);
        }
    }
});

// Handles messages events
function handleMessage(sender_psid, received_message) {

    let response;

    // Check if the message contains text
    if (received_message.text) {

        // Create the payload for a basic text message
        response = {
            "text": `Activity confirmed, Thank you!`
        }
    }

    // Sends the response message
    callSendAPI(sender_psid, response);
}


function callSendAPI(sender_psid, response) {
    // Construct the message body
    let request_body = {
        "recipient": {
            "id": sender_psid
        },
        "message": response
    }

    request({
        "uri": "https://graph.facebook.com/v2.6/me/messages",
        "qs": { "access_token": "EAAFa9EpgZAdIBAPZAOxwmopn8gBdvU7EwQJJ6FyLgDP1asd0NCQzkHZBEozlJORiEZAt1DutjcI0MUUo9nnaqGZB69jXFxJ66XesU7sccpqsVrEPovOtkBls12rb7p2VeiCoCzJG7rZCXCEyPVDGoUSf0chwRFwCxTWkJ1bCwpPKBWt9dJ5xN7" },
        "method": "POST",
        "json": request_body
    }, (err, res, body) => {
        if (!err) {
            console.log('message sent!')
        } else {
            console.error("Unable to send message:" + err);
        }
    });
}