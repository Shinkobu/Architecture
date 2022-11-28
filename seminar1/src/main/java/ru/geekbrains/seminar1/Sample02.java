package ru.geekbrains.seminar1;

import java.util.ArrayList;
import java.util.Collection;

public class Sample02 {

    public static void main(String[] args) {

        MyLogObserver1 myLogObserver1 = new MyLogObserver1();
        MyLogObserver2 myLogObserver2 = new MyLogObserver2();

        MyLogFileWriter myLogFileWriter = new MyLogFileWriter();
        myLogFileWriter.RegisterObserver(myLogObserver1);
        myLogFileWriter.RegisterObserver(myLogObserver2);

        myLogFileWriter.writeString("Hello, GeekBrains!");

        myLogFileWriter.RemoveObserver(myLogObserver2);

        myLogFileWriter.writeString("Hello, GeekBrains!");
    }

}

/**
 * Наблюдатель 1
 */
class MyLogObserver1 implements  FileObserver{

    @Override
    public void UpdateState() {
        System.out.println("MyLogObserver1 -> Файл был изменен ...");
    }
}

/**
 * Наблюдатель 2
 */
class MyLogObserver2 implements  FileObserver{

    @Override
    public void UpdateState() {
        System.out.println("MyLogObserver2 -> Файл был изменен ...");
    }
}

/**
 * Интерфейс наблюдателя
 */
interface FileObserver{
    void UpdateState();
}

class MyLogFileWriter implements  FileChanger{

    private Collection<FileObserver> _observers = new ArrayList<>();

    public void writeString(String str){
        //TODO: Обращаемся к файлу, добавляем строку к текстовому файлу ...
        NotifyAll();

    }

    @Override
    public void RegisterObserver(FileObserver o) {
        _observers.add(o);
    }

    @Override
    public void RemoveObserver(FileObserver o) {
        _observers.remove(o);
    }

    @Override
    public void NotifyAll() {
        for (FileObserver o : _observers){
            o.UpdateState();
        }
    }
}

interface FileChanger{
    void RegisterObserver(FileObserver o);
    void RemoveObserver(FileObserver o);
    void NotifyAll();
}