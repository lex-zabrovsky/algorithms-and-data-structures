namespace Algorithms
{
  public class QuickFindUF
  {
    private readonly int[] data;

    public QuickFindUF(int size)
    {
      data = new int[size];

      for (int i = 0; i < size; i++)
        data[i] = i;
    }

    public void Union(int p, int q)
    {
      int pValue = data[p];
      int qValue = data[q];

      for (int i = 0; i < data.Length; i++)
        if (data[i] == pValue) data[i] = qValue;
    }

    public bool Connected(int p, int q)
    {
      return data[p] == data[q];
    }

    public override string ToString()
    {
      string result = "";
      foreach (var i in data)
        result += data[i].ToString();

      return result;
    }
  }
}