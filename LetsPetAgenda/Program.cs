using System;

namespace Agendas
{
    public class Schedule
    {
        private int id;
        private Animal pet;
        private Tutor tutor;
        private List<Service> serviceToComplete;
        private DateTime scheduleDate;
        private Employee employee;
        private string specialNeeds;
        private double valueTotal;
        private double valueDiscount;
        private double valueFine;
        private bool completed;
        private string incident;
        private IncidentLevel level;
        private PaymentMethod method;
        private DateTime expectedDepartureTime;
        private DateTime realDepartureTime;

        public int Id { get => id; private set => id = value; }
        public Animal Pet { get => pet; private set => pet = value; }
        public Tutor Tutor { get => tutor; private set => tutor = value; }
        public List<Service> ServiceToComplete { get => serviceToComplete; private set => serviceToComplete = value; }
        public DateTime ScheduleDate { get => scheduleDate; private set => scheduleDate = value; }
        public Employee Employee { get => employee; private set => employee = value; }
        public string SpecialNeeds { get => specialNeeds; private set => specialNeeds = value; }
        public double ValueTotal { get => valueTotal; private set => valueTotal = value; }
        public double ValueDiscount { get => valueDiscount; private set => valueDiscount = value; }
        public double ValueFine { get => valueFine; private set => valueFine = value; }
        public bool Completed { get => completed; private set => completed = value; }
        public string Incident { get => incident; private set => incident = value; }
        public IncidentLevel Level { get => level; private set => level = value; }
        public PaymentMethod Method { get => method; private set => method = value; }
        public DateTime ExpectedDepartureTime { get => expectedDepartureTime; private set => expectedDepartureTime = value; }
        public DateTime RealDepartureTime { get => realDepartureTime; private set => realDepartureTime = value; }
    }



    public enum IncidentLevel
    {
        leve = 1,
        médio = 2,
        grave = 3
    }
    public enum PaymentMethod
    {
        dinheiro = 1,
        cartão = 2,
        pix = 3
    }
    //Temporário
    public class Animal : DadosCadastro
    {
        public string Nome { get; set; }
        public string Raca { get; set; }
        public string Cor { get; set; }
        public Porte Porte { get; set; }
        public decimal Peso { get; set; }
        public int Idade { get { return IdadeCompleta(); } }
        public DateTime Nascimento { get; set; }
        private List<string> DoencasAlergias { get; set; } = new();
        public bool Agressivo { get; set; }
        public char Sexo { get; set; }
        public bool Castrado { get; set; }
        private int IdadeCompleta()
        {
            if (Nascimento.Month > DateTime.Now.Month)
            {
                return (DateTime.Now.Year - Nascimento.Year) - 1;
            }
            else if (Nascimento.Month < DateTime.Now.Month)
            {
                return (DateTime.Now.Year - Nascimento.Year);
            }
            else
            {
                if (Nascimento.Day < DateTime.Now.Day)
                {
                    return (DateTime.Now.Year - Nascimento.Year);
                }
                else
                {
                    return (DateTime.Now.Year - Nascimento.Year) - 1;
                }
            }
        }
    }
    public class DadosCadastro
    {
        public Guid Codigo { get; private set; } = Guid.NewGuid();
        public DateTime DataCadastro { get; private set; } = DateTime.Now;

    }

    public enum Porte
    {
        Pequeno = 1,
        Grande = 2,
    }
    public enum Especie
    {
        Cachorro = 1,
        Gato = 2,
    }

    public class Tutor
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public string telefone { get; set; }
        public string whatsapp { get; set; }
        public string email { get; set; }
        public string endereco { get; set; }

    }
    public class Service
    {
        public string tipoDeServico { get; set; } //banho ou tosa
        public string especie { get; set; } //cão ou gato
        public string nome { get; set; }
        public string porte { get; set; }
        public double preco { get; set; }
        public DateTime duracaoDoServico { get; set; }

    }
    public class Employee
    {
        public string nome { get; set; }
        public DateTime dataDoDesligamento { get; set; }
        public List<Service> executa { get; set; }
        public TimeOnly horarioEntrada { get; set; }
        public TimeOnly horarioEntradaIntervalo { get; set; }
        public TimeOnly horarioRetornoIntervalo { get; set; }
        public TimeOnly horarioSaida { get; set; }
        public bool atendeEspeciais { get; set; }
        public bool atendeAgressivosAgitados { get; set; }
        public bool ativo { get; set; }
    }