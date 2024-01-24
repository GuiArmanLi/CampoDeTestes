<?php
class Person
{
    private $id;
    private $name;
    private $age;
    private $weigth;
    private $isAlive;

    public function getId()
    {
        return $this->id;
    }

    public function getName()
    {
        return $this->name;
    }

    public function setName($name)
    {
        $this->name = $name;
    }

    public function getAge()
    {
        return $this->age;
    }

    public function setAge($age)
    {
        $this->age = $age;
    }

    public function getWeigth()
    {
        return $this->weigth;
    }

    public function setWeigth($weigth)
    {
        $this->weigth = $weigth;
    }

    public function getIsAlive()
    {
        return $this->isAlive;
    }

    public function setIsAlive($isAlive)
    {
        $this->isAlive = $isAlive;
    }

    public function __construct()
    {
        $this->id = uniqid();
    }
    public static function fullConstruct($name, $age, $weigth, $isAlive)
    {
        $person = new Person();

        $person->id = uniqid();
        $person->name = $name;
        $person->age = $age;
        $person->weigth = $weigth;
        $person->isAlive = $isAlive;

        return $person;
    }
}

$guilherme = new Person();
$kauan = Person::fullConstruct("Kauan", 20, 70.8, true);


foreach(get_object_vars($kauan) as $att){
    echo $att;
}

