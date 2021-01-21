led = () => {
    let h2 = document.querySelectorAll('h2');
    for (let i = 0; i < h2.length; i++) {
        // h2[i].classList.add('blue');
        setInterval(() => {
            h2[i].classList.toggle('red');
        }, 500)
        // Object.assign(h2[i].style, {
        //     color: '#4ee0fa'
        // })
    }
}
led();


// responsive thì chạy, còn chế độ pc thì không (buồn thực sự)
// window.scroll = function () {
//     scrollFunction();
// }
// scrollFunction = () => {
//     if (document.body.scrollTop > 80 || document.documentElement.scrollTop > 80) {
//         Object.assign(document.querySelector('#header').style, {
//             lineHeight: '60px',
//             height: '60px',
//             backgroundColor: '#090909',
//             display: 'none'
//         })
//         Object.assign(document.querySelector('.nav-logo').style, {
//             lineHeight: '60px',
//             fontSize: '40px',
//             marginTop: '30px'
//         })
//         document.querySelector('.nav-search').style.lineHeight = '60px';
//         document.querySelector('.nav-shopping').style.lineHeight = '60px';
//         document.querySelector('.nav-user').style.lineHeight = '60px';
//     } else {
//         Object.assign(document.querySelector('#header').style, {
//             lineHeight: '80px',
//             height: '80px',
//         })
//         document.querySelector('.nav-logo').style.lineHeight = '80px';
//     }
// }