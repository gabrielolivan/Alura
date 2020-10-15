const sqlite3 = require('sqlite3');
const { open } = require('sqlite');

const executaQuery = async (res, query) => {
const conexao = await open({
  filename: './database.sqlite',
  driver: sqlite3.Database,
});
  const resBD = await conexao.all(query);
  res.json(resBD);
await conexao.close();
};

module.exports = executaQuery;