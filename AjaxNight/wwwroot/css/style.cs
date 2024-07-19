﻿:root {
    --glow-color: yellow;
--background - color: black;
}

* {
    box - sizing: border - box;
margin: 0;
padding: 0;
}

html, body {
    height: 100 %;
font - family: "Raleway", sans - serif;
background - color: var(--background - color);
color: var(--glow - color);
display: flex;
justify - content: center;
align - items: center;
flex - direction: column;
}

.glowing - title {
    font - size: 3em;
    text - align: center;
    margin - bottom: 1em;
animation: blink 1.5s infinite alternate; /* Yanıp sönme animasyonu eklendi */
}

    .glowing - title span {
        position: relative;
display: inline - block;
animation: glow 1.5s infinite alternate;
    }

@@keyframes glow
{
    from
    {
        text - shadow: 0 0 10px var(--glow - color), 0 0 20px var(--glow - color), 0 0 30px var(--glow - color);
    }

    to
    {
        text - shadow: 0 0 20px var(--glow - color), 0 0 30px var(--glow - color), 0 0 40px var(--glow - color);
    }
}

@@keyframes blink
{
    0% {
    opacity: 1;
    }

    50% {
    opacity: 0.5;
    }

    100% {
    opacity: 1;
    }
}

.chain - animation {
    font - size: 2em;
    margin - top: 1em;
animation: blink 1.5s infinite alternate; /* Yanıp sönme animasyonu eklendi */
}

    .chain - animation span {
        display: inline - block;
animation: chain - blink 1.5s infinite alternate;
    }

@@keyframes chain-blink {
    0% {
        opacity: 1;
    }

    50 % {
opacity: 0.5;
}

100 % {
opacity: 1;
}
}

.form - container {
    max - width: 100 %;
padding: 20px;
    background - color: rgba(28, 28, 28, 0.8); /* Şeffaf arka plan */
    border - radius: 10px;
    box - shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
    margin - top: 1em;
    text - align: center;
}

.form - group {
    margin - bottom: 20px;
}

.form - control {
    background - color: rgba(51, 51, 51, 0.8); /* Şeffaf arka plan */
border: 1px solid var(--glow - color); /* Parlak kenar */
color: var(--glow - color);
padding: 10px 15px;
    font - size: 1.2em;
transition: border - color 0.3s ease-in-out;
}

    .form - control:focus {
        border-color: var(--glow - color); /* Odaklandığında parlak sınır */
box - shadow: 0 0 8px var(--glow-color);
    }

.btn - custom {
position: relative;
color: var(--glow - color);
cursor: pointer;
padding: 0.5em 1.5em;
border: 0.2em solid var(--glow - color);
    border - radius: 0.5em;
background: none;
perspective: 2em;
    font - family: "Raleway", sans - serif;
    font - size: 1.5em;
    font - weight: 900;
    letter - spacing: 0.1em;
    box - shadow: inset 0px 0px 0.5em 0px var(--glow - color), 0px 0px 0.5em 0px var(--glow - color);
animation: border - flicker 2s linear infinite;
    margin - top: 1em;
}

    .btn - custom:hover {
        color: rgba(0, 0, 0, 0.8);
text - shadow: none;
animation: none;
    }

        .btn - custom:hover::before {
filter: blur(1.5em);
opacity: 1;
}

        .btn - custom:hover::after {
opacity: 1;
}

@@keyframes border-flicker {
    0% {
        opacity: 0.1;
    }

    2 % {
opacity: 1;
}

4 % {
opacity: 0.1;
}

8 % {
opacity: 1;
}

70 % {
opacity: 0.7;
}

100 % {
opacity: 1;
}
}

@@media only screen and (max-width: 600px) {
    .btn-custom {
        font-size: 1em;
    }
}

.popup {
    display: none;
position: fixed;
left: 50 %;
top: 50 %;
transform: translate(-50 %, -50 %);
background - color: rgba(0, 0, 0, 0.8);
padding: 20px;
border - radius: 10px;
z - index: 1000;
}

.popup - content {
color: var(--glow - color);
    text - align: center;
}

.popup - close {
position: absolute;
top: 10px;
right: 10px;
cursor: pointer;
color: var(--glow - color);
    font - size: 1.5em;
}
}