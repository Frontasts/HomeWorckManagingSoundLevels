using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorckManagingSoundLevels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Управление звуковыми уровнями ===");
            Console.WriteLine();

            AudioController audio = new AudioController(Volume.Medium);
            Console.WriteLine("Начальное состояние:");
            Console.WriteLine(audio.GetStatus());
            Console.WriteLine();

            Console.WriteLine("Переключение уровней:");

            audio.SetVolume(Volume.Mute);
            Console.WriteLine(audio.GetStatus());

            audio.SetVolume(Volume.Low);
            Console.WriteLine(audio.GetStatus());

            audio.SetVolume(Volume.High);
            Console.WriteLine(audio.GetStatus());

            Console.WriteLine();
            Console.WriteLine("Перебор всех доступных уровней:");

            Volume[] levels = new Volume[]
            {
                Volume.Mute,
                Volume.Low,
                Volume.Medium,
                Volume.High
            };

            for (int i = 0; i < levels.Length; i = i + 1)
            {
                audio.SetVolume(levels[i]);
                Console.WriteLine($"  [{i}] {audio.GetStatus()}");
            }

            Console.WriteLine();
            Console.WriteLine($"Текущий уровень через GetVolume(): {audio.GetVolume()}");
            Console.WriteLine($"Текущий процент через GetVolumePercent(): {audio.GetVolumePercent()}%");
        }
    }
}
