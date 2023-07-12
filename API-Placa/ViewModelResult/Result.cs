namespace API_Placa.ViewModelResult
{
    public class Result<T>
    {
        public T Data { get; set; }
        public List<string> Erros { get; set; }
        public Result(T data) => Data = data;
        public Result(string erro) => Erros.Add(erro);
        public Result(T data, string erro)
        {
            Data = data;
            Erros.Add(erro);
        }
        public Result(List<string> erros) => Erros.AddRange(erros);
    }
}
