let express = require('express');
let bodyParser = require('body-parser');
let app = express();
app.use(express.urlencoded());
let port = process.env.PORT || 3002;
app.set('view-engine', 'ejs');
app.use(bodyParser.urlencoded({ extended: true }));
app.use(bodyParser.json())

app.get('/', (req,res)=>{
    res.render('index.ejs');
});
//app.post('/', (req, res) => {
//    res.render('index.ejs');
//});

//app.get('/Login', (req, res) => {
//    res.render('index.ejs')
//});

app.post('/Login', (req, res) => {
    let email = req.body.email;
    let password = req.body.password;

    const sql = require('mssql/msnodesqlv8')

    const pool = new sql.ConnectionPool({
        database: 'Kontactkeeper',
        server: 'localhost',
        driver: 'msnodesqlv8',
        options: {
            trustedConnection: true
        }
    })
    let dbid = 0;
    pool.connect().then(() => {
        pool.request().query('select * from tblEndUser', (err, result) => {
            if (err) throw err;
            let found = false;
            for (var i = 0; i < result.recordset.length; i++) {
                if (email == result.recordset[i].Email) {
                    if (password == result.recordset[i].Password) {
                        found = true;
                        dbid = result.recordset[i].ID;
                        fname = result.recordset[i].FName;
                        lname = result.recordset[i].LName;
                        uname = result.recordset[i].UName;
                        password = result.recordset[i].Password;
                        cellno = result.recordset[i].Cellnumber;
                        WAVerified = result.recordset[i].WAVerified;
                        email = result.recordset[i].Email;
                        EmailVerified = result.recordset[i].EmailVerified;
                        fbid = result.recordset[i].FBID;
                        FBVerified = result.recordset[i].FBVerified;
                        res.render('website.ejs', { dbid: dbid, fname:fname, lname:lname, uname:uname, password:password, cellno:cellno, WAVerified:WAVerified, email:email, EmailVerified:EmailVerified, fbid:fbid, FBVerified:FBVerified });
                        res.end();
                        break;
                    }
                }
            }
            if (!found) {
                res.send('Try again');
            }
        })
    })
    
});

app.get('/Save', (req, res) => {
    res.render('website.ejs');
});

app.post('/Save', (req, res) => {
    const sql = require('mssql/msnodesqlv8')

    const pool = new sql.ConnectionPool({
        database: 'Kontactkeeper',
        server: 'localhost',
        driver: 'msnodesqlv8',
        options: {
            trustedConnection: true
        }
    })
    let fname = req.body.EFirstName;
    let lname = req.body.ELastName;
    let cellno = req.body.ENumber;
    let email = req.body.EEmail;
    let fbid = req.body.EFBID;
    let uname = req.body.EUsername;
    let password = req.body.EPassword;

    console.log(fname);
    console.log(lname);

    let query = `INSERT INTO tblEndUser (FName, LName, UName, Password, Cellnumber, WAVerified, Email, EmailVerified, FBID, FBVerified) VALUES ('${fname}','${lname}','${uname}','${password}','${cellno}','${req.body.WAVerified}','${email}','${req.body.EmailVerified}','${fbid}','${req.body.FBVerified}')`;
    pool.connect().then(() => {
        pool.query(`delete from tblEndUser where ID = ${req.body.EID}`, (err, result) => {
            if (err) throw err;
            console.log(result);
        })
        pool.query(query, (err, result) => {
            if (err) throw err;
            console.log(result);
        })
    })
    res.render('index.ejs');
});

app.listen(port, ()=>{
    console.log(`Listening on Port ${port}`);
})

