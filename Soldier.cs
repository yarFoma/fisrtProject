namespace VolumeBot;

public class Soldier
{
    /// <summary>
    /// Если солдат устал, то он бежит в два раза медленнее
    /// </summary>
    private const int fatiguiFactor = 2;
    
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public bool IsDolboeb { get; set; }
    
    public int CommandId { get; set; }
    
    /// <summary>
    /// Солдат по умолчанию уставший
    /// </summary>
    public bool IsTyred { get; set; } = true;
    
    /// <summary>
    /// Среднйи темп бега солдата в минутах за километр
    /// </summary>
    public int AverageTape { get; set; }

    public void KillEnemies()
    {
        if (IsDolboeb == false)
        {
            Console.WriteLine("enemy is killed");
        }
        else
        {
            Console.WriteLine("alien is killed");
        }
        Cry();
        
    }

    /// <summary>
    /// Метод возвращает за сколько минут солдат пробегает заданую дистанцию
    /// </summary>
    /// <param name="distance">дистанция в километрах</param>
    /// <returns>Количество минут за которое солдат пробегает заданую дистанцию</returns>
    public int Run(int distance)
    {
        int resultInMinutes;
        // проверяем устал ли солдат
        // Если устал, то бежит дистанцию в своем среднем темпе, к которому применяется корректировочный коэфф
        // Если не устал, то бежит в своем среднем темпе (AverageTape)
        if(IsTyred == true)
        {
            resultInMinutes = (AverageTape * distance) * fatiguiFactor;
        }
        else
        {
            resultInMinutes = AverageTape * distance;
        }
        return resultInMinutes;
    }
    
    // Реализовать метод вывода досье на каждого солдата (имя , возраст, усталость, долбаеб или нет, средний темп)
    public void PrintDossie()
    {
        Console.WriteLine($"Имя: {Name}\n" +
                   $"Возраст: {Age}\n" +
                   $"Средний темп: {AverageTape}\n" +
                   $"{(IsDolboeb ? $"{Name} долбоеб" : $"{Name} не долбоеб")}\n" +
                   $"{(IsTyred ? $"{Name} устал" : $"{Name} не устал")}");
    }
    
    

    
    
    
    
    private void Cry()
    {
        Console.WriteLine("SIR YEAH SIR");
    }
    
    
    
 
}
