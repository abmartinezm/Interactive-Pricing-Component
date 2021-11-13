:root {
  /*## Colors*/
  /*### Primary*/
  --Soft-Cyan: hsl(174, 67%, 68%);
  /*(Full Slider Bar)*/
  --Strong-Cyan: hsl(174, 86%, 45%);
  /*(Slider Backround)*/
  --Light-Grayish-Red: hsl(14, 92%, 95%);
  /*(Discount Background)*/
  --Light-Red: hsl(15, 100%, 70%);
  /*(Discount Text)*/
  --Pale-Blue: hsl(226, 100%, 87%);
  /*(CTA Text)*/
  /*### Neutral*/
  --White: hsl(0, 0%, 100%);
  /*(Pricing Component Background)*/
  --Very-Pale-Blue: hsl(230, 100%, 99%);
  /*(Main Background)*/
  --Light-Grayish-Blue: hsl(224, 65%, 95%);
  /*(Empty Slider Bar)*/
  --Light-Grayish-Blue: hsl(223, 50%, 87%);
  /*(Toggle Background)*/
  --Grayish-Blue: hsl(225, 20%, 60%);
  /* (Text)*/
  --Dark-Desaturated-Blue: hsl(227, 35%, 25%);
  /*(Text & CTA Background)*/
}

body {
  font-family: "Manrope", sans-serif;
}
body .container {
  width: 88vw;
  height: auto;
  padding: 6vw;
}
body .container header {
  width: 100vw;
  height: 30vh;
  background-image: url("../images/pattern-circles.svg");
  background-position: 50% 10%;
  background-size: 30%;
  background-repeat: no-repeat;
}
body .container header .head-traffic {
  width: 100%;
  height: auto;
  margin: 0 auto;
  margin-bottom: 10vh;
  margin-top: 8vh;
  padding-top: 5vh;
}
body .container header .head-traffic .title {
  font-size: 20px;
  text-align: center;
}
body .container header .head-traffic .subtitle {
  width: 40%;
  height: auto;
  margin: 0 auto;
  text-align: center;
  font-size: 14px;
  font-weight: 100;
  color: var(--Grayish-Blue);
}
body .content {
  box-shadow: rgba(0, 0, 0, 0.35) 0px 5px 15px;
  position: relative;
  padding: 10%;
}
body .content main {
  /* The slider itself */
}
body .content main label {
  width: 100%;
  height: auto;
  margin: 0 auto;
  display: flex;
  justify-content: center;
  text-align: center;
  text-transform: uppercase;
  margin-bottom: 5vh;
  font-size: 13px;
  color: var(--Grayish-Blue);
}
body .content main .thousands {
  margin: 0vw 2vw 0 0vw;
}
body .content main .slidecontainer {
  width: 100%;
}
body .content main .slider {
  -webkit-appearance: none;
  width: 100%;
  height: 8px;
  border-radius: 5px;
  background: var(--Soft-Cyan);
  outline: none;
  opacity: 0.7;
  -webkit-transition: 0.2s;
  transition: opacity 0.2s;
}
body .content main .slider::-webkit-slider-thumb {
  -webkit-appearance: none;
  appearance: none;
  width: 42px;
  height: 42px;
  border-radius: 50%;
  border: none;
  background: var(--Strong-Cyan);
  cursor: pointer;
}
body .content main .slider::-moz-range-thumb {
  width: 42px;
  height: 42px;
  border-radius: 50%;
  border: none;
  background: var(--Strong-Cyan);
  background-image: url("../images/icon-slider.svg");
  background-repeat: no-repeat;
  background-position: center;
  cursor: pointer;
  box-shadow: 0 6px 15px #10d5c2;
}
body .content main input[type=range]::-moz-range-progress {
  height: 8px;
  background-color: var(--Strong-Cyan);
  border-radius: 50%;
}
body .content main input[type=range]::-ms-fill-lower {
  height: 8px;
  background-color: var(--Strong-Cyan);
  border-radius: 50%;
}
body .content main .output {
  width: 60%;
  float: right;
  margin-top: -13vh;
  height: auto;
  display: flex;
  position: relative;
  align-items: center;
}
body .content main .output output {
  width: 60%;
  position: absolute;
  right: 0;
  height: auto;
  margin: 0 auto;
  display: flex;
  font-size: 30px;
  margin-top: 0;
  font-weight: 700;
}
body .content main .output span {
  width: 50%;
  position: absolute;
  right: 0;
}
body .content main .output p {
  font-size: 30px;
  width: 5%;
  font-weight: 700;
  margin-left: 28vw;
  visibility: hidden;
  color: transparent;
}
body .content main .month {
  font-size: 13px;
  color: var(--Grayish-Blue);
  font-weight: 100;
  margin-left: 2vw;
  display: flex;
  align-items: center;
}
body .content main .billing {
  width: 85%;
  height: auto;
  display: flex;
  margin: 0 auto;
  justify-content: space-between;
  margin-top: 5vh;
  /*------ ADDED CSS ---------*/
}
body .content main .billing p {
  font-size: 12px;
  color: var(--Grayish-Blue);
  cursor: pointer;
}
body .content main .billing .switch {
  position: relative;
  display: inline-block;
  width: 70px;
  height: 34px;
}
body .content main .billing .switch input {
  display: none;
}
body .content main .billing .slider {
  position: absolute;
  height: 25px;
  width: 50px;
  cursor: pointer;
  top: 0.5vh;
  left: 0;
  right: 0;
  bottom: 0;
  background-color: var(--Light-Grayish-Blue);
  -webkit-transition: 0.4s;
  transition: 0.4s;
  border-radius: 34px;
}
body .content main .billing .slider:before {
  position: absolute;
  content: "";
  height: 17px;
  width: 17px;
  left: 4px;
  bottom: 4px;
  background-color: white;
  -webkit-transition: 0.4s;
  transition: 0.4s;
  border-radius: 50%;
}
body .content main .billing input:checked + .slider {
  background-color: var(--Soft-Cyan);
}
body .content main .billing input:focus + .slider {
  box-shadow: 0 0 1px #2196F3;
}
body .content main .billing input:checked + .slider:before {
  -webkit-transform: translateX(26px);
  -ms-transform: translateX(26px);
  transform: translateX(25px);
}
body .content main .billing .slider:after {
  color: white;
  display: block;
  position: absolute;
  transform: translate(-50%, -50%);
  top: 50%;
  left: 50%;
  font-size: 10px;
  font-family: Verdana, sans-serif;
}
body .content main .billing .m-billing {
  margin-right: 1vw;
}
body .content main .billing span {
  color: var(--Light-Red);
  font-weight: 600;
  margin-left: 0;
}
body .content footer .extra-info {
  width: 50%;
  height: auto;
  margin: 0 auto;
}
body .content footer .extra-info .extras p {
  font-size: 13px;
  color: var(--Grayish-Blue);
  text-align: center;
}
body .content footer .extra-info .extras p svg {
  margin-right: 2vw;
}
body .content footer .extra-info .btn {
  width: 100%;
  height: auto;
  margin: 0 auto;
  display: flex;
  justify-content: center;
  margin-top: 5vh;
}
body .content footer .extra-info .btn button {
  margin: 0 auto;
  background: var(--Dark-Desaturated-Blue);
  height: 5vh;
  width: 75%;
  outline: none;
  border: none;
  border-radius: 25px;
  color: var(--Very-Pale-Blue);
  cursor: pointer;
  margin-bottom: 10vh;
}
@media (min-width: 501px) and (max-width: 1600px) {
  body .container {
    width: 515px;
    margin: 0 auto;
  }
  body .container header {
    margin-top: -17vh;
    width: 100%;
    height: 28vh;
    background-image: url("../images/pattern-circles.svg");
    background-position: 50% 80%;
    background-size: 20%;
    background-repeat: no-repeat;
  }
  body .container header .title {
    margin-top: 3vh;
  }
  body .container main {
    width: 100%;
    height: auto;
  }
  body .container main label {
    width: 15%;
    float: left;
    text-align: left;
  }
  body .container main .output output {
    width: auto;
    right: 4vw;
  }
  body .container main .output .month {
    width: auto;
    right: 0;
  }
  body .container main .billing {
    width: 35%;
  }
  body .container footer .extra-info {
    width: 100%;
    display: flex;
  }
  body .container footer .extra-info p {
    width: 150%;
    text-align: left;
  }
  body .container footer .extra-info p svg {
    margin-right: 5%;
  }
  body .container footer .btn {
    width: 50%;
    margin-right: 0%;
  }
  body .container footer .btn button {
    margin-right: 0%;
    width: 40%;
  }
}
@media screen and (max-width: 1660px) {
  body .container main .billing {
    width: 60%;
  }
}
@media screen and (max-width: 1160px) {
  body .container main label {
    width: 15%;
    margin-left: 2vw;
  }
  body .container main .output p {
    margin-right: 2vw;
  }
  body .container main .billing {
    width: 50%;
  }
}
@media screen and (max-width: 955px) {
  body .container main label {
    width: 15%;
    margin-left: 3vw;
  }
  body .container main output {
    width: 40%;
  }
  body .container main .billing {
    width: 60%;
  }
}
@media screen and (max-width: 850px) {
  body .container header .head-traffi .subtitle {
    width: 60%;
  }
  body .container main label {
    width: 15%;
    margin-left: 6vw;
  }
  body .container main output {
    width: 40%;
  }
  body .container main .billing {
    width: 80%;
  }
  body .container footer .extra-info .btn button {
    width: 60%;
  }
}
@media screen and (max-width: 670px) {
  body .container main label {
    width: 15%;
    margin-left: 7vw;
  }
  body .container main .output output {
    width: 45%;
  }
  body .container main .billing {
    width: 90%;
  }
  body .container footer .extra-info .btn button {
    width: 70%;
  }
}

/*# sourceMappingURL=styles.cs.map */
