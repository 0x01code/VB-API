<?php

/* Connent Database */
$con = new mysqli('localhost', 'Database_Username', 'Database_Password', 'Database_Name');
$con->set_charset('utf-8');
if ($con->connect_error) {
    die($con->connect_error);
}

$action = ($_GET['action'] != null) ? $_GET['action'] : null;
$username = ($_GET['username'] != null) ? $_GET['username'] : null;
$password = ($_GET['password'] != null) ? $_GET['password'] : null;

if ($action != '' && $username != '' && $password != '') {
    switch ($action) {
        case 'register':
            $result = $con->query("SELECT * FROM member WHERE username='{$username}'");
            if ($result->num_rows == 0) {
                $con->query("INSERT INTO member (username,password) VALUES ('{$username}','{$password}')");
                echo 'success';
            } else {
                echo 'Plase Try Again.';
            }
            break;
        case 'login':
            $result = $con->query("SELECT * FROM member WHERE username='{$username}' AND password='{$password}'");
            if ($result->num_rows > 0) {
                echo 'success';
            } else {
                echo 'incorrect';
            }
            break;

        default:
            echo 'invalid action';
            break;
    }
}
