namespace task1;

public  class Cache<T>
{
  
List<T> values = new List<T>();

   public void Add(T  t){
        values.Add(t);
   }
    public List<T> GetValue(){
        return values;
    }
    public void Remove(T t){
        values.Remove(t);
    }
}
