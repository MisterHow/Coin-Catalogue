import Swiper from 'swiper';
var swiper = new Swiper('.swiper-container', {
    loop: true,
    autoplay: {
        delay: 300,
        disableOnInteraction: false,
    },
    pagination: {
        el: '.swiper-pagination',
    },
    speed: 3000,
    spaceBetween: 100
});
export default swiper;
//# sourceMappingURL=swiper.js.map