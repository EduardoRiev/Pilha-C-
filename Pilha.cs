class Pilha
{
  private int tamanho;
  private int topo;
  private int[] Vetor = int[tamanho];
  public Pilha(int tamanho, int topo) 
  {
    this.tamanho = tamanho;
    this.topo = topo;
  }
  public int Size()
  {
    return tamanho + 1;
  }
  public int Top()
  {
    return topo;
  }
  public void Pop()
  {
    if (IsEmpty() == false) topo--;
    else Console.WriteLine("Pilha vazia");
  }
  public bool IsEmpty()
  {
    for (int i = 0; i < Vetor.Length; i++)
    {
      if (Vetor[i] == null) return true;
      else return false;
    }
  }
  public void Push(int n)
  {
    if (Size() == Vetor.length) DuplicaArray;
    topo++;
  }
  public void DuplicaArray() 
  {
    tamanho *= 2;
  }
  public void Listar()
  {
    for (int i = 0; i < tamanho; i++)
    {
      if (Vetor[i] == null) Console.Write("-");
      else Console.Write($"{Vetor[i] }");
    }
  }
}
