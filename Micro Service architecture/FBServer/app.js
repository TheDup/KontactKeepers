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