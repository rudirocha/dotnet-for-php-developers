
<?php
/**
 This is just a quick way to call all the files!
 */

 require 'class.php';

 $userObj = new App\Person('John', 'Doe', 'jhgjahgdjashgfjagf');

 echo $userObj->getToken();