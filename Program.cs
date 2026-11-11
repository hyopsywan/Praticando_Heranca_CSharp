using Heranca;
using AtividadeHerancaPOO;
using Praticando_Heranca_CSharp;


// EX 1 -
Motocicleta moto = new Motocicleta("HarleyDavidson", "Low Rider S", 1.923);
Carro carro = new Carro("Fiat", "Siena", 4);

//moto.ExibirInformacoes();
//carro.ExibirInformacoes();

// EX 2 - 

Ebook e1 = new Ebook("Cem Chances", 5.99m, 641);
CursosOnline c1 = new CursosOnline("Jornada do Artista", 00.00m, 43);

//e1.ExibirInformacoes();
//c1.ExibirInformacoes();

// EX 3 - 

JogoDigital j1 = new JogoDigital("Phasmophobia", "Steam Store");
JogoFisico j2 = new JogoFisico("Black Stories", "Gálapagos Jogos");

//j1.JogosInformacoes();
//j2.JogosInformacoes();

// EX 4 - 

NotificacaoEmail e = new NotificacaoEmail("Bem-Vindo ao MusicHub!");
NotificacaoPush p = new NotificacaoPush("Bem-Vindo ao MusicHub!");
NotificacaoSMS s = new NotificacaoSMS("Bem-Vindo ao MusicHub!");

//e.Enviar();
//p.Enviar();
//s.Enviar();
