package ru.geekbrains.lesson8.MVP;

public class HwCheck {
    // Александр, проверил вашу работу, в целом, все хорошо, единственный момент,
    // я бы добавил реализацию изменения брони, помимо прочего, еще и на уровень модели, например, следующим образом:

    /**
     * Бронирование столика
     * @param reservationDate Дата бронирования
     * @param name Имя
     */
//    public int reservationTable(Date reservationDate, int tableNo, String name){
//        Optional<Table> table = loadTables().stream().filter(t -> t.getNo() == tableNo).findFirst();
//        if (table.isPresent()){
//            Reservation reservation = new Reservation(reservationDate, name);
//            table.get().getReservations().add(reservation);
//            return reservation.getId();
//        }
//        throw new RuntimeException("Некорректный номер столика");
    }

    /**
     * Поменять бронь столика
     * @param oldReservation номер старого резерва (для снятия)
     * @param reservationDate дата резерва столика
     * @param tableNo номер столика
     * @param name Имя
     */
//    public int changeReservationTable(int oldReservation, Date reservationDate, int tableNo, String name){
//
//        for (Table table: tables) {
//            Optional<Reservation> reservation = table.getReservations().stream().filter(r -> r.getId() == oldReservation).findFirst();
//            if (reservation.isPresent())
//            {
//                table.getReservations().remove(reservation.get());
//                return reservationTable(reservationDate, tableNo, name);
//            }
//        }
//        throw new RuntimeException("Некорректный номер брони");
    //}
    //Заметьте, тут я сам объект брони удаляю из коллекции объектов брони столика,
    // а вот потом уже добавляю новый экземпляр брони, пользуюясь уже разработанным
    // методом reservationTable, и вот далее мы этот метод протягиваем уже так как вы
    // это выполнили с вашим методом deleteReservationTable.

//}
