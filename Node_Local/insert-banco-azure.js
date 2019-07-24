var pasta_projeto_site = 'Site_BootstrapAzure';

var porta_serial = require('serialport');
var leitura_recebida = porta_serial.parsers.Readline;
var banco = require(`../${pasta_projeto_site}/app-banco`);

require('events').EventEmitter.defaultMaxListeners = 15;

function iniciar_escuta() {

    porta_serial.list().then(entradas_seriais => {

        var entradas_seriais_arduino = entradas_seriais.filter(entrada_serial => {
            return entrada_serial.vendorId == 2341 && entrada_serial.productId == 43;
        });

        if (entradas_seriais_arduino.length != 1) {
            throw new Error("Nenhum Arduino está conectado ou porta USB sem comunicação ou mais de um Arduino conectado");
        }
        console.log("Arduino conectado na COM %s", entradas_seriais_arduino[0].comName);

        return entradas_seriais_arduino[0].comName;

    }).then(arduinoCom => {

        var arduino = new porta_serial(arduinoCom, {
            baudRate: 9600
        });

        var parser = new leitura_recebida();
        arduino.pipe(parser);

        console.error('Iniciando escuta do Arduino');

        parser.on('data', (dados) => {
            console.error(`Recebeu novos dados do Arduino: ${dados}`);
            try {
                var leitura = dados.split(',');
                var silo1 = {
                    temp1: Number(((((Math.random() * ((0.6 - 0.8))) + 0.6).toFixed(2)) * Number(leitura[0])).toFixed(1)),
                    umid1: Number(((((Math.random() * ((0.75 - 0.81))) + 0.75).toFixed(2)) * Number(leitura[1])).toFixed(1)),
                    temp2: Number(((((Math.random() * ((0.35 - 0.62))) + 0.35).toFixed(2)) * Number(leitura[0])).toFixed(1)),
                    umid2: Number(((((Math.random() * ((0.15 - 0.19))) + 0.15).toFixed(2)) * Number(leitura[1])).toFixed(1)),
                    temp3: Number(((((Math.random() * ((0.35 - 0.62))) + 0.35).toFixed(2)) * Number(leitura[0])).toFixed(1)),
                    umid3: Number(((((Math.random() * ((0.15 - 0.19))) + 0.15).toFixed(2)) * Number(leitura[1])).toFixed(1)),
                    temp4: Number(((((Math.random() * ((0.35 - 0.62))) + 0.35).toFixed(2)) * Number(leitura[0])).toFixed(1)),
                    umid4: Number(((((Math.random() * ((0.15 - 0.19))) + 0.15).toFixed(2)) * Number(leitura[1])).toFixed(1))
                }
                var silo2 = {
                    temp1: Number(((((Math.random() * ((0.6 - 0.61))) + 0.6).toFixed(2)) * Number(leitura[0])).toFixed(1)),
                    umid1: Number(((((Math.random() * ((0.75 - 0.76))) + 0.75).toFixed(2)) * Number(leitura[1])).toFixed(1)),
                    temp2: Number(((((Math.random() * ((0.35 - 0.36))) + 0.35).toFixed(2)) * Number(leitura[0])).toFixed(1)),
                    umid2: Number(((((Math.random() * ((0.15 - 0.16))) + 0.15).toFixed(2)) * Number(leitura[1])).toFixed(1)),
                    temp3: Number(((((Math.random() * ((0.35 - 0.36))) + 0.35).toFixed(2)) * Number(leitura[0])).toFixed(1)),
                    umid3: Number(((((Math.random() * ((0.15 - 0.16))) + 0.15).toFixed(2)) * Number(leitura[1])).toFixed(1)),
                    temp4: Number(((((Math.random() * ((0.35 - 0.36))) + 0.35).toFixed(2)) * Number(leitura[0])).toFixed(1)),
                    umid4: Number(((((Math.random() * ((0.15 - 0.16))) + 0.15).toFixed(2)) * Number(leitura[1])).toFixed(1))
                }
                var silo3 = {
                    temp1: Number(((((Math.random() * ((0.6 - 0.61))) + 0.6).toFixed(2)) * Number(leitura[0])).toFixed(1)),
                    umid1: Number(((((Math.random() * ((0.75 - 0.76))) + 0.75).toFixed(2)) * Number(leitura[1])).toFixed(1)),
                    temp2: Number(((((Math.random() * ((0.35 - 0.36))) + 0.35).toFixed(2)) * Number(leitura[0])).toFixed(1)),
                    umid2: Number(((((Math.random() * ((0.15 - 0.16))) + 0.15).toFixed(2)) * Number(leitura[1])).toFixed(1)),
                    temp3: Number(((((Math.random() * ((0.35 - 0.36))) + 0.35).toFixed(2)) * Number(leitura[0])).toFixed(1)),
                    umid3: Number(((((Math.random() * ((0.15 - 0.16))) + 0.15).toFixed(2)) * Number(leitura[1])).toFixed(1)),
                    temp4: Number(((((Math.random() * ((0.35 - 0.36))) + 0.35).toFixed(2)) * Number(leitura[0])).toFixed(1)),
                    umid4: Number(((((Math.random() * ((0.15 - 0.16))) + 0.15).toFixed(2)) * Number(leitura[1])).toFixed(1))
                }
                var silo4 = {
                    temp1: Number(((((Math.random() * ((0.6 - 0.61))) + 0.6).toFixed(2)) * Number(leitura[0])).toFixed(1)),
                    umid1: Number(((((Math.random() * ((0.75 - 0.76))) + 0.75).toFixed(2)) * Number(leitura[1])).toFixed(1)),
                    temp2: Number(((((Math.random() * ((0.35 - 0.36))) + 0.35).toFixed(2)) * Number(leitura[0])).toFixed(1)),
                    umid2: Number(((((Math.random() * ((0.15 - 0.16))) + 0.15).toFixed(2)) * Number(leitura[1])).toFixed(1)),
                    temp3: Number(((((Math.random() * ((0.35 - 0.36))) + 0.35).toFixed(2)) * Number(leitura[0])).toFixed(1)),
                    umid3: Number(((((Math.random() * ((0.15 - 0.16))) + 0.15).toFixed(2)) * Number(leitura[1])).toFixed(1)),
                    temp4: Number(((((Math.random() * ((0.35 - 0.36))) + 0.35).toFixed(2)) * Number(leitura[0])).toFixed(1)),
                    umid4: Number(((((Math.random() * ((0.15 - 0.16))) + 0.15).toFixed(2)) * Number(leitura[1])).toFixed(1))
                }
                console.log(silo1, silo2, silo3, silo4);
                registrar_leitura(silo1, silo2, silo3, silo4);
            } catch (e) {
                throw new Error(`Erro ao tratar os dados recebidos do Arduino: ${e}`);
                
            }
        });

    }).catch(error => console.error(`Erro ao receber dados do Arduino ${error}`));
}

function registrar_leitura(silo1, silo2, silo3, silo4) {

    if (efetuando_insert) {
        setTimeout(() => {
            registrar_leitura(silo1, silo2, silo3, silo4);
        }, 5000);
        return;
    }

    efetuando_insert = true;

    banco.conectar().then(pool => {
            // return pool.request().query(`SELECT COUNT(temperatura) as 'cont' FROzzM Leitura`);
            return pool.request().query(`INSERT INTO Leitura (temperatura,umidade,fkSensor,fkProducao,momentoLeitura)
        values 
        (${silo1.temp1},${silo1.umid1},1,1,CURRENT_TIMESTAMP),
        (${silo1.temp2},${silo1.umid2},2,1,CURRENT_TIMESTAMP),
        (${silo1.temp3},${silo1.umid3},3,1,CURRENT_TIMESTAMP),
        (${silo1.temp4},${silo1.umid4},4,1,CURRENT_TIMESTAMP),
        (${silo2.temp1},${silo2.umid1},5,2,CURRENT_TIMESTAMP),
        (${silo2.temp2},${silo2.umid2},6,2,CURRENT_TIMESTAMP),
        (${silo2.temp3},${silo2.umid3},7,2,CURRENT_TIMESTAMP),
        (${silo2.temp4},${silo2.umid4},8,2,CURRENT_TIMESTAMP),
        (${silo3.temp1},${silo3.umid1},9,3,CURRENT_TIMESTAMP),
        (${silo3.temp2},${silo3.umid2},10,3,CURRENT_TIMESTAMP),
        (${silo3.temp3},${silo3.umid3},11,3,CURRENT_TIMESTAMP),
        (${silo3.temp4},${silo3.umid4},12,3,CURRENT_TIMESTAMP),
        (${silo4.temp1},${silo4.umid1},13,4,CURRENT_TIMESTAMP),
        (${silo4.temp2},${silo4.umid2},14,4,CURRENT_TIMESTAMP),
        (${silo4.temp3},${silo4.umid3},15,4,CURRENT_TIMESTAMP),
        (${silo4.temp4},${silo4.umid4},16,4,CURRENT_TIMESTAMP);`);

        })
        .catch(err => {

            var erro = `Erro ao tentar registrar aquisição na base: ${err}`;
            console.error(erro);

        }).finally(() => {
            banco.sql.close();
            efetuando_insert = false;
        });

}

var efetuando_insert = false;

iniciar_escuta();