const express = require('express')
const app = express()
const port = 3000
const sqlite3 = require('sqlite3').verbose();


this.db = new sqlite3.Database('./studentData.sqlite', (err) => {
    if (err) {
      console.log('Could not connect to database', err)
    } else {
      console.log('Connected to database')
    }
})
  

app.get('/', (req, res) => res.send('Hello World!'))



app.listen(port, () => console.log(`Example app listening at http://localhost:${port}`))