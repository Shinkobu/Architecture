package ru.geekbrains.seminar1.modelelements;

public class Flash {

    public Collection <Point3D> location;
    public Collection <Angle3D> angle;
    public Collection <Color> color;

    public void setLocation(Collection<Point3D> location) {
        this.location = location;
    }

    public void setAngle(Collection<Angle3D> angle) {
        this.angle = angle;
    }

    public void setColor(Collection<Color> color) {
        Color = color;
    }

    public void setPower(Collection<Float> power) {
        Power = power;
    }

    public Flash(Collection<Point3D> location, Collection<Angle3D> angle, Collection<Color> color, Collection<Float> power) {
        this.location = location;
        this.angle = angle;
        Color = color;
        Power = power;
    }

    public Collection <Float> Power;

    public void rotate(Angle3D angle3D) {
        //todo
    }

    public void move(Point3D point3D) {
        //todo
    }


}
