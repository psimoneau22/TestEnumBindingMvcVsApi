document.querySelector('.button1').addEventListener('click',  () => {
    console.log('mvc controller test');
    send("test");
});

document.querySelector('.button2').addEventListener('click', () => {
    console.log('api controller test');
    send("api/test");
});

function send(path) {
    fetch(path, {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify({
            Filter: ["Val1", "Val2", "Val3", "ValNotExists"],
        })
    })
    .then(r => r.json())
    .then(console.log);
}

console.log('loaded');