"use strict";
var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", { value: true });
const express_1 = __importDefault(require("express"));
const body_parser_1 = __importDefault(require("body-parser"));
const fs_1 = __importDefault(require("fs"));
const app = (0, express_1.default)();
app.use(body_parser_1.default.json());
const dbFile = '../db.json';
// Function to read the database file
const readDatabase = () => {
    if (fs_1.default.existsSync(dbFile)) {
        const data = fs_1.default.readFileSync(dbFile, 'utf-8');
        return JSON.parse(data);
    }
    return [];
};
// Function to write to the database file
const writeDatabase = (data) => {
    fs_1.default.writeFileSync(dbFile, JSON.stringify(data, null, 2));
};
// Ping endpoint
app.get('/ping', (req, res) => {
    res.send(true);
});
// Submit endpoint
app.post('/submit', (req, res) => {
    const { name, email, phone, github_link, stopwatch_time } = req.body;
    const submissions = readDatabase();
    submissions.push({ name, email, phone, github_link, stopwatch_time });
    writeDatabase(submissions);
    res.send({ message: 'Submission successful' });
});
// Read endpoint
app.get('/read', (req, res) => {
    const { index } = req.query;
    const submissions = readDatabase();
    const idx = parseInt(index, 10);
    if (idx >= 0 && idx < submissions.length) {
        res.send(submissions[idx]);
    }
    else {
        res.status(404).send({ message: 'Submission not found' });
    }
});
const PORT = 3000;
app.listen(PORT, () => {
    console.log(`Server is running on http://localhost:${PORT}`);
});
