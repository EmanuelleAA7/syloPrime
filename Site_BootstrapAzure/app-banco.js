var desenvolvimento = false;

var configuracoes = {
    producao: {
        server: "bd-gus.database.windows.net",
        user: "adm",
        password: "#Gf47252577880",
        database: "Bd-gus",
        options: {
            encrypt: true
        },
        
        pool: {
             max: 10000,
             min: 0,
             idleTimeoutMillis: 30000,
             connectionTimeout: 5000
         }

   },
    desenvolvimento: {
        server: "BASETESTE.database.windows.net",
        user: "usuariotestes",
        password: "senhatestes",
        database: "BASETESTE",
        options: {
            encrypt: true
        }
    }
}

var sql = require('mssql');
sql.on('error', err => {
    console.error(`Erro de Conexão: ${err}`);
});

var perfil = desenvolvimento ? 'desenvolvimento' : 'producao';

// function conectar() {
//     //   return sql.connect(configuracoes[perfil])
//     return new sql.ConnectionPool(configuracoes[perfil]).connect();
// }

function conectar2() {
    return sql.connect(configuracoes[perfil])
        //   return new sql.ConnectionPool(configuracoes[perfil]).connect();  
}

module.exports = {
    conectar2: conectar2,
    // conectar: conectar,
    sql: sql
}
