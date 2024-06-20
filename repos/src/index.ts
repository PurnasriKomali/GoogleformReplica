import express from 'express';
import bodyParser from 'body-parser';
import fs from 'fs';

const app = express();
app.use(bodyParser.json());

const dbFile = 'db.json';

const readDatabase = (): any[] => {
    if (fs.existsSync(dbFile)) {
        const data = fs.readFileSync(dbFile, 'utf-8');
        return JSON.parse(data);
    }
    return [];
};

const writeDatabase = (data: any[]): void => {
    fs.writeFileSync(dbFile, JSON.stringify(data, null, 2));
};

app.get('/ping', (req, res) => {
    res.send(true);
});

app.post('/submit', (req, res) => {
    const { name, email, phone, github_link, stopwatch_time } = req.body;
    const submissions = readDatabase();
    submissions.push({ name, email, phone, github_link, stopwatch_time });
    writeDatabase(submissions);
    res.send({ message: 'Submission successful' });
});

app.get('/read', (req, res) => {
    const { index } = req.query;
    const submissions = readDatabase();
    const idx = parseInt(index as string, 10);
    if (idx >= 0 && idx < submissions.length) {
        res.send(submissions[idx]);
    } else {
        res.status(404).send({ message: 'Submission not found' });
    }
});

const PORT = 3000;
app.listen(PORT, () => {
    console.log(`Server is running on http://localhost:${PORT}`);
});
