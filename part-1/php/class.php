<?php
namespace App;
abstract class User {

    protected function disableUser()
    {
        // do something
    }
}

interface IPerson {
    public function doSomething();
}

class Person extends User implements IPerson {

    public $firstName;
    public $lastName;

    protected $createdAt;

    private $token;

    public function __construct($theFirstName, $theLastName, $token)
    {
        $this->firstName = $theFirstName;
        $this->lastName = $theLastName;
        $this->createdAt = date('Y-m-d H:i:s');
        $this->token = $token;
    }

    public function getToken() {
        return $this->token;
    }

    public function doSomething()
    {
        // something
    }
}