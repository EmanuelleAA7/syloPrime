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
<<<<<<< HEAD
        // pool: {
        //     max: 4,
        //     min: 1,
        //     idleTimeoutMillis: 30000,
        //     connectionTimeout: 5000
        // }
=======
        pool: {
            max: 4,
            min: 1,
            idleTimeoutMillis: 20000,
            connectionTimeout: 5000
        }
>>>>>>> 6928c2595030c8b535a41d8815afe8d6ef3624f1
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