.controlls {
  display: flex;
  justify-content: space-around;
  align-items: center;
  flex-direction: column;
  background-color: var(--color-blue);
}
.controlls .control {
  width: calc(5vh + 5px);
  height: calc(5vh + 5px);
  background-color: var(--color-grey4);
  padding: 1rem;
  cursor: pointer;
  border-radius: 50%;
  display: flex;
  justify-content: center;
  align-items: center;
  margin: 0.7rem 0;
  box-shadow: 0 3px 15px rgba(0, 0, 0, 0.3);
}
.controlls .control i {
  font-size: 1.2rem;
  color: var(--color-grey2);
  pointer-events: none;
}

@media (min-width: 768px) {
  .controlls {
    justify-content: center;
  }
}
@media (min-width: 768px) {
  .controlls {
    justify-content: center;
    background-color: var(--color-white);
  }
}
.controlls.home {
  justify-content: center;
}

.controlls.about,
.controlls.about,
.controlls.portfolio,
.controlls.contact {
  position: fixed;
  justify-content: space-around;
  top: 0;
  left: 0;
  width: 100%;
  flex-direction: row;
}

.theme-switch-wrapper {
  display: flex;
  align-items: center;
  z-index: 100;
  position: absolute;
  right: 20%;
  top: 3%;
}
.theme-switch-wrapper span {
  margin-right: 10px;
  font-size: 1rem;
}
.theme-switch-wrapper i {
  color: var(--color-grey4);
}

@media (min-width: 769px) {
  .theme-switch-wrapper {
    right: 3%;
    top: 10%;
  }
}
.toggle-text {
  position: relative;
  top: -4px;
  right: 5px;
  color: var(--color-grey4);
}

.theme-switch {
  display: inline-block;
  height: 34px;
  position: relative;
  width: 60px;
}

.theme-switch input {
  display: none;
}

.slider {
  background: #ccc;
  bottom: 0;
  cursor: pointer;
  left: 0;
  position: absolute;
  right: 0;
  top: 0;
  transition: 0.4s;
}

.slider::before {
  background: var(--color-white);
  bottom: 4px;
  content: "";
  height: 26px;
  left: 4px;
  position: absolute;
  transition: 0.4s;
  width: 26px;
}

input:checked + .slider {
  background: var(--color-sand);
}

input:checked + .slider::before {
  transform: translateX(26px);
}

.slider.round {
  border-radius: 34px;
}

.slider.round::before {
  border-radius: 50%;
}

.fas {
  font-size: 30px;
  margin-right: 5px;
}

.header-content {
  position: relative;
  width: 100%;
  height: 100%;
  background-image: url("../img/face.jpg");
  background-position: 75%;
}
.header-content .header-background {
  width: 100%;
  height: 100%;
  position: absolute;
  left: 0;
  top: 0;
  display: flex;
  justify-content: center;
  align-items: center;
}
.header-content .header-background .h-shape {
  display: none;
}
.header-content .header-main {
  width: 100%;
  height: 100%;
  position: absolute;
  left: 0;
  top: 0;
  z-index: 100;
  display: flex;
  justify-content: center;
  align-items: center;
  flex-direction: column;
}
.header-content .header-main .name {
  font-size: calc(1rem + 1vh);
  color: var(--color-grey5);
  display: flex;
  justify-content: center;
  align-items: center;
}
.header-content .header-main .name span {
  font-size: calc(1rem + 1vh);
  font-weight: 1200;
  margin: 12px;
}
.header-content .header-main h4 {
  color: var(--color-grey5);
  font-size: calc(0.5rem + 1vh);
  text-align: center;
}
.header-content .header-main h4 .portfolio-link {
  margin-left: 0;
}
.header-content .header-main p {
  display: block;
  margin-top: 15px;
  color: var(--color-grey5);
  text-align: center;
  font-size: calc(0.5rem + 1vh);
}
.header-content .header-main .btn-con {
  color: var(--color-grey5);
}
.header-content .header-main .btn-con__link {
  border-radius: 30px;
  color: var(--color-white);
  font-weight: 600;
  position: relative;
  display: flex;
  align-items: center;
  overflow: hidden;
  background-color: var(--color-grey5);
}
.header-content .header-main .btn-con__link__text {
  padding: 0 2rem;
}
.header-content .header-main .btn-con__link__icon {
  background-color: var(--color-blue);
  display: flex;
  justify-content: center;
  align-items: center;
  border-radius: 50%;
  padding: 1rem;
  transform: translateX(10px);
}
.header-content .header-main .btn-con__link__icon:hover {
  visibility: hidden;
  z-index: -100;
}
.header-content .header-main .portfolio-link-con {
  text-align: center;
  font-size: calc(0.5rem + 1vh);
}
.header-content .header-main > * {
  font-weight: 1000;
  letter-spacing: 2px;
  margin-top: 25px;
}

@media (min-width: 768px) {
  .header-content .header-background {
    width: 100%;
    height: 100%;
    position: absolute;
    left: 0;
    top: 0;
    display: flex;
    justify-content: center;
    align-items: center;
  }
}
@media (min-width: 1000px) {
  .header-content .header-background {
    width: 100%;
    height: 100%;
    position: absolute;
    left: 0;
    top: 0;
    display: flex;
    justify-content: center;
    align-items: center;
  }
  .header-content .header-background .h-shape {
    display: block;
    background-color: var(--color-secondary);
    width: 80%;
    height: 80%;
    transition: all 0.4s ease-in-out;
    z-index: 1;
    clip-path: polygon(0% 15%, 15% 15%, 15% 0%, 85% 0%, 85% 15%, 100% 15%, 100% 85%, 85% 85%, 85% 100%, 15% 100%, 15% 85%, 0% 85%);
  }
}
header {
  color: var(--color-white);
  overflow: hidden;
  z-index: 100;
}
header h2 {
  color: var(--color-secondary);
}

.about-container {
  margin-top: 6rem;
  overflow: hidden;
  width: 100%;
}
.about-container .about-container_title {
  position: relative;
  margin-top: 1rem;
}
.about-container .about-container_title h2 {
  color: var(--color-sand);
  text-align: center;
  position: relative;
  text-transform: uppercase;
  font-size: calc(2rem + 1vh);
  font-size: 700;
  z-index: 2;
}
.about-container .about-container_title .bg-text {
  position: absolute;
  top: 50%;
  left: 50%;
  color: var(--color-grey5);
  transition: all 0.4s ease-in-out;
  z-index: 1;
  font-weight: 800;
  font-size: calc(1rem + 1vh);
  text-transform: uppercase;
  text-shadow: var(--color-blue) 1px 0 10px;
}
.about-container .about-container_info {
  margin-top: 1rem;
  display: flex;
  justify-content: center;
  align-items: center;
  flex-direction: column;
}
.about-container .about-container_info .left-about h4 {
  margin: 1rem 0;
  font-size: calc(0.5rem + 1vh);
  text-transform: uppercase;
  color: var(--color-blue);
  text-align: center;
}
.about-container .about-container_info .left-about div {
  padding: 10px;
  text-align: justify;
  margin: 1rem 0;
  line-height: 2rem;
  width: 100%;
  display: block;
  color: var(--color-grey5);
  overflow: hidden;
  word-wrap: break-word;
}
.about-container .about-container_info .btn-con {
  color: var(--color-grey5);
  width: 80%;
  display: flex;
  justify-content: center;
  align-items: center;
}
.about-container .about-container_info .btn-con__link {
  border-radius: 30px;
  color: var(--color-white);
  font-weight: 600;
  position: relative;
  display: flex;
  align-items: center;
  overflow: hidden;
  background-color: var(--color-grey5);
}
.about-container .about-container_info .btn-con__link__text {
  padding: 0 2rem;
}
.about-container .about-container_info .btn-con__link__icon {
  background-color: var(--color-blue);
  display: flex;
  justify-content: center;
  align-items: center;
  border-radius: 50%;
  padding: 1rem;
  transform: translateX(10px);
}
.about-container .about-container_info .right-about {
  margin-top: 2.5rem;
  width: 100%;
}
.about-container .about-container_info .right-about .about-item .abt-text {
  display: flex;
  justify-content: flex-start;
  align-items: flex-start;
  padding: 1rem;
}
.about-container .about-container_info .right-about .about-item .abt-text .large-text {
  color: var(--color-blue);
}
.about-container .about-container_info .right-about .about-item .abt-text .small-text {
  font-size: calc(0.4rem + 1vh);
  overflow: hidden;
}
.about-container .about-stats {
  display: flex;
  justify-content: center;
  align-items: center;
  flex-direction: column;
}
.about-container .about-stats .stat-title {
  font-size: calc(0.5rem + 1vh);
  color: var(--color-blue);
  margin-top: 2.5rem;
  text-transform: uppercase;
  text-align: center;
}
.about-container .about-stats .about-stats-con {
  display: grid;
  grid-template-rows: repeat(5, 60px);
  align-self: flex-start;
  width: 90%;
}
.about-container .about-stats .about-stats-con .progress-bars {
  margin: 1rem;
}
.about-container .about-stats .about-stats-con .progress-bars .progress-title {
  font-weight: 500;
  color: var(--color-grey5);
}
.about-container .about-stats .about-stats-con .progress-bars .progress {
  height: 1rem;
  background-color: var(--color-sand);
  margin-bottom: 1rem;
  position: relative;
  border: 2px solid black;
}
.about-container .about-stats .about-stats-con .progress-bars .progress.html {
  display: flex;
  width: 20%;
  height: 10px;
}
.about-container .about-stats .about-stats-con .progress-bars .progress.css {
  display: flex;
  width: 40%;
  height: 10px;
}
.about-container .about-stats .about-stats-con .progress-bars .progress.scss {
  display: flex;
  width: 40%;
  height: 10px;
}
.about-container .about-stats .about-stats-con .progress-bars .progress.javascript {
  display: flex;
  width: 60%;
  height: 10px;
}
.about-container .about-stats .about-stats-con .progress-bars .progress.api {
  display: flex;
  width: 70%;
  height: 10px;
}
.about-container .about-stats .about-stats-con .progress-bars .progress.react {
  display: flex;
  width: 75%;
  height: 10px;
}
.about-container .timeline {
  display: flex;
  justify-content: flex-start;
  flex-direction: column;
  padding-bottom: 6rem;
}
.about-container .timeline .timeline-item {
  position: relative;
  padding-left: 5rem;
  border-left: 1px solid var(--color-grey5);
}
.about-container .timeline .timeline-item .tl-icon {
  position: absolute;
  left: 5px;
  top: 0;
  width: 50px;
  height: 50px;
  border-radius: 50%;
  display: flex;
  justify-content: center;
  align-items: center;
  color: var(--color-blue);
}
.about-container .timeline .timeline-item .tl-icon i {
  font-size: 1.3rem;
}
.about-container .timeline .timeline-item .tl-duration {
  padding: 0.6rem 0.8rem;
  background-color: var(--color-grey5);
  border-radius: 15px;
  display: inline-block;
  font-size: 0.8rem;
  text-transform: uppercase;
  font-weight: 500;
}
.about-container .timeline .timeline-item h5 {
  text-align: justify;
  color: var(--color-blue);
}

@media (min-width: 769px) {
  .about-container {
    margin: calc(3rem + 1vh);
  }
  .about-container .about-container_title h2 {
    font-size: calc(3rem + 2vh);
  }
  .about-container .about-container_title h2 span {
    font-size: calc(3rem + 2vh);
  }
  .about-container .about-container_title .bg-text {
    display: none;
  }
  .about-container .about-container_info .left-about h4 {
    font-size: calc(0.8rem + 2vh);
  }
  .about-container .about-stats .stat-title {
    font-size: calc(0.8rem + 2vh);
  }
  .about-container .about-stats .about-stats-con {
    align-self: center;
  }
  .about-container .timeline {
    display: flex;
    justify-content: center;
    align-items: center;
    flex-direction: row;
  }
  .about-container .timeline .timeline-item {
    width: 50%;
    justify-self: flex-end;
  }
}
@media (min-width: 1000px) {
  .about-container .about-container_info .right-about {
    display: grid;
    grid-template-columns: 1fr 1fr 1fr;
    grid-template-rows: 1fr;
    grid-template-areas: "myown  course learn";
  }
  .about-container .about-container_info .right-about .about-item {
    width: 100%;
    height: 100%;
    padding: 10%;
  }
  .about-container .about-container_info .right-about .myown {
    grid-area: myown;
  }
  .about-container .about-container_info .right-about .course {
    grid-area: course;
  }
  .about-container .about-container_info .right-about .learn {
    grid-area: learn;
  }
  .about-container .about-stats .about-stats-con {
    align-self: center;
  }
  .about-container .timeline {
    display: flex;
    justify-content: center;
    align-items: flex-start;
    flex-direction: column;
  }
  .about-container .timeline .timeline-item {
    margin-top: 2rem;
  }
}
.portfolio-container {
  margin: calc(1rem + 1vh);
  margin-top: 6rem;
}
.portfolio-container .portfolio-title {
  margin-bottom: 3rem;
}
.portfolio-container .portfolio-title h2 {
  color: var(--color-sand);
  text-align: center;
  position: relative;
  text-transform: uppercase;
  font-size: calc(2rem + 1vh);
  font-size: 700;
  z-index: 2;
  margin-top: 1rem;
}
.portfolio-container .portfolio-title span {
  color: var(--color-secondary);
  z-index: 2;
  font-size: calc(2rem + 1vh);
  position: relative;
}
.portfolio-container .portfolio-title .bg-text {
  position: absolute;
  top: 50%;
  left: 50%;
  color: var(--color-grey5);
  transition: all 0.4s ease-in-out;
  z-index: 1;
  font-weight: 800;
  font-size: calc(1rem + 1vh);
  text-transform: uppercase;
  text-shadow: var(--color-secondary) 1px 0 10px;
}
.portfolio-container p {
  padding: 0;
  text-align: justify;
  margin: 1rem 0;
  line-height: 2rem;
  color: var(--color-grey5);
  display: block;
  overflow: hidden;
}
.portfolio-container h2 {
  margin: 1rem 0;
  font-size: calc(1.2rem + 1vh);
  text-transform: uppercase;
  color: var(--color-blue);
  text-align: center;
}
.portfolio-container .portfolios .portfolio-item.myown {
  position: relative;
  border-radius: 15px;
}
.portfolio-container .portfolios .portfolio-item.myown .imagecon.two {
  display: flex;
  justify-content: center;
  align-items: center;
  flex-direction: column;
  background-color: var(--color-sand);
  width: 100%;
  height: 100%;
}
.portfolio-container .portfolios .portfolio-item.myown .imagecon.two .imagecon-title {
  font-size: calc(0.8rem + 1vh);
  margin-bottom: 1rem;
}
.portfolio-container .portfolios .portfolio-item.myown .imagecon.two .img-con {
  color: var(--color-grey2);
  text-decoration: wavy;
  margin-bottom: 2rem;
}
.portfolio-container .portfolios .portfolio-item.myown .imagecon.two .img-con img {
  margin-top: 2rem;
  width: 90%;
  height: 90%;
}
.portfolio-container .portfolios .portfolio-item.myown .hover-items {
  width: 100%;
  height: 100%;
  background-color: var(--color-blue);
  border: 2px solid pink;
  position: absolute;
  left: 0;
  top: 0;
  border-radius: 15px;
  display: flex;
  justify-content: center;
  align-items: center;
  flex-direction: column;
  opacity: 0;
  transform: scale(0);
  transition: all 0.4s ease-in-out;
}
.portfolio-container .portfolios .portfolio-item.myown .hover-items .technologies-con {
  width: 90%;
}
.portfolio-container .portfolios .portfolio-item.myown .hover-items .technologies-con .technologies-con-title {
  color: var(--color-sand);
  margin-bottom: 1rem;
}
.portfolio-container .portfolios .portfolio-item.myown .hover-items .technologies-con .technologies-list {
  display: grid;
  grid-gap: 10px;
  grid-template-columns: repeat(auto-fill, minmax(80px, 1fr));
  list-style-type: circle;
  list-style-image: linear-gradient(--color-sand);
  color: var(--color-blue);
}
.portfolio-container .portfolios .portfolio-item.myown .hover-items .technologies-con .technologies-list.two-col {
  display: grid;
  grid-template-columns: repeat(2, 1fr);
}
.portfolio-container .portfolios .portfolio-item.myown .hover-items .technologies-con .technologies-list.two-col li {
  margin: 0.5rem;
}
.portfolio-container .portfolios .portfolio-item.myown .hover-items .technologies-con .technologies-list.three-col {
  display: grid;
  grid-template-columns: repeat(3, 1fr);
}
.portfolio-container .portfolios .portfolio-item.myown .hover-items .technologies-con .technologies-list.four-col {
  display: grid;
  grid-template-columns: repeat(4, 100px);
}
.portfolio-container .portfolios .portfolio-item.myown .hover-items .technologies-con .technologies-list.five-col {
  display: grid;
  grid-template-columns: repeat(5, 100px);
}
.portfolio-container .portfolios .portfolio-item.myown .hover-items h3 {
  font-size: 1.5rem;
  color: var(--color-sand);
  margin-bottom: 1.5rem;
}
.portfolio-container .portfolios .portfolio-item.myown .hover-items .icons {
  display: flex;
  justify-content: center;
  align-items: center;
}
.portfolio-container .portfolios .portfolio-item.myown .hover-items .icons .icon {
  background-color: var(--color-primary);
  border-radius: 50%;
  width: 50px;
  height: 50px;
  display: flex;
  justify-content: center;
  align-items: center;
  margin: 0 1rem 1rem 1rem;
  cursor: pointer;
  transition: all 0.4s ease-in-out;
}
.portfolio-container .portfolios .portfolio-item.myown .hover-items .icons .icon i {
  font-size: 1.5rem;
  color: var(--color-white);
  margin: 0 1rem;
}
.portfolio-container .portfolios .portfolio-item.myown .hover-items .icons .icon:hover {
  background-color: var(--color-white);
}
.portfolio-container .portfolios .portfolio-item.myown .hover-items .icons .icon:hover i {
  color: var(--color-primary);
}
.portfolio-container .portfolios .stars-break {
  display: flex;
  justify-content: space-around;
  width: 100%;
  height: 50px;
  color: var(--color-sand);
}
.portfolio-container .portfolios .portfolio-item.course {
  position: relative;
  border-radius: 15px;
}
.portfolio-container .portfolios .portfolio-item.course h1 {
  color: var(--color-sand);
}
.portfolio-container .portfolios .portfolio-item.course .imagecon.two {
  display: flex;
  justify-content: center;
  align-items: center;
  flex-direction: column;
  background-color: var(--color-sand);
}
.portfolio-container .portfolios .portfolio-item.course .imagecon.two .imagecon-title {
  font-size: calc(0.8rem + 1vh);
  margin-bottom: 1rem;
}
.portfolio-container .portfolios .portfolio-item.course .imagecon.two .img-con {
  color: var(--color-grey2);
  text-decoration: wavy;
  margin-bottom: 2rem;
}
.portfolio-container .portfolios .portfolio-item.course .imagecon.two .img-con img {
  margin-top: 2rem;
  width: 90%;
  height: 90%;
}
.portfolio-container .portfolios .portfolio-item.course .hover-items {
  width: 100%;
  height: 100%;
  background-color: var(--color-blue);
  border: 2px solid pink;
  position: absolute;
  left: 0;
  top: 0;
  border-radius: 15px;
  display: flex;
  justify-content: center;
  align-items: center;
  flex-direction: column;
  opacity: 0;
  transform: scale(0);
  transition: all 0.4s ease-in-out;
}
.portfolio-container .portfolios .portfolio-item.course .hover-items .technologies-con {
  width: 90%;
}
.portfolio-container .portfolios .portfolio-item.course .hover-items .technologies-con .technologies-con-title {
  color: var(--color-sand);
  margin-bottom: 1rem;
}
.portfolio-container .portfolios .portfolio-item.course .hover-items .technologies-con .technologies-list {
  display: grid;
  grid-gap: 10px;
  grid-template-columns: repeat(auto-fill, minmax(80px, 1fr));
  list-style-type: circle;
  list-style-image: linear-gradient(--color-sand);
  color: var(--color-blue);
}
.portfolio-container .portfolios .portfolio-item.course .hover-items .technologies-con .technologies-list.two-col {
  display: grid;
  grid-template-columns: repeat(2, 1fr);
}
.portfolio-container .portfolios .portfolio-item.course .hover-items .technologies-con .technologies-list.two-col li {
  margin: 0.5rem;
}
.portfolio-container .portfolios .portfolio-item.course .hover-items .technologies-con .technologies-list.three-col {
  display: grid;
  grid-template-columns: repeat(3, 1fr);
}
.portfolio-container .portfolios .portfolio-item.course .hover-items .technologies-con .technologies-list.four-col {
  display: grid;
  grid-template-columns: repeat(4, 100px);
}
.portfolio-container .portfolios .portfolio-item.course .hover-items .technologies-con .technologies-list.five-col {
  display: grid;
  grid-template-columns: repeat(5, 100px);
}
.portfolio-container .portfolios .portfolio-item.course .hover-items h3 {
  font-size: 1.5rem;
  color: var(--color-sand);
  margin-bottom: 1.5rem;
}
.portfolio-container .portfolios .portfolio-item.course .hover-items .icons {
  display: flex;
  justify-content: center;
  align-items: center;
}
.portfolio-container .portfolios .portfolio-item.course .hover-items .icons .icon {
  background-color: var(--color-primary);
  border-radius: 50%;
  width: 50px;
  height: 50px;
  display: flex;
  justify-content: center;
  align-items: center;
  margin: 0 1rem 1rem 1rem;
  cursor: pointer;
  transition: all 0.4s ease-in-out;
}
.portfolio-container .portfolios .portfolio-item.course .hover-items .icons .icon i {
  font-size: 1.5rem;
  color: var(--color-white);
  margin: 0 1rem;
}
.portfolio-container .portfolios .portfolio-item.course .hover-items .icons .icon:hover {
  background-color: var(--color-white);
}
.portfolio-container .portfolios .portfolio-item.course .hover-items .icons .icon:hover i {
  color: var(--color-primary);
}
.portfolio-container .portfolio-item.myown:active .hover-items {
  display: flex;
  justify-content: center;
  align-items: center;
  background-color: black;
  opacity: 1;
  transform: scale(100%);
}
.portfolio-container .portfolio-item.myown:active .hover-items .technologies-con h3 {
  color: black;
}
.portfolio-container .portfolio-item.course:active .hover-items {
  display: flex;
  justify-content: center;
  align-items: center;
  background-color: black;
  opacity: 1;
  transform: scale(100%);
}
.portfolio-container .portfolio-item.course:active .hover-items .technologies-con h3 {
  color: black;
}

@media (min-width: 769px) {
  .portfolio-container .portfolios .portfolio-item.myown .imagecon.two {
    justify-content: flex-start;
  }
}
.contact-container {
  margin: calc(1rem + 1vh);
  margin-top: 6rem;
}
.contact-container .contact-title {
  margin-bottom: 3rem;
}
.contact-container h2 {
  color: var(--color-sand);
  text-align: center;
  position: relative;
  text-transform: uppercase;
  font-size: calc(2rem + 1vh);
  font-size: 700;
  z-index: 2;
  margin-top: 1rem;
}
.contact-container .contact-content-con {
  display: flex;
  padding-top: 3.5rem;
  color: var(--color-blue);
}
.contact-container .contact-content-con .left-contact {
  flex: 2;
}
.contact-container .contact-content-con .left-contact h4 {
  margin-top: 1rem;
  font-size: 2rem;
  text-transform: uppercase;
}
.contact-container .contact-content-con .left-contact p {
  margin: 1rem 0;
  line-height: 2rem;
}
.contact-container .contact-content-con .left-contact .contact-info {
  padding: 2rem;
}
.contact-container .contact-content-con .left-contact .contact-info .contact-item {
  display: flex;
  align-items: center;
  justify-content: space-between;
}
.contact-container .contact-content-con .left-contact .contact-info .contact-item p {
  margin: 0.3rem 0 !important;
  padding: 0 !important;
}
.contact-container .contact-content-con .left-contact .contact-info .contact-item .icon {
  display: grid;
  grid-template-columns: 40px 1fr;
}
.contact-container .contact-content-con .left-contact .contact-info .contact-item .icon i {
  display: flex;
  align-items: center;
  font-size: 1.3rem;
}
.contact-container .contact-content-con .left-contact .contact-info .contact-icon {
  display: flex;
  margin-top: 2rem;
}
.contact-container .contact-content-con .left-contact .contact-info .contact-icon a {
  display: flex;
  justify-content: center;
  align-items: center;
  color: var(--color-white);
  background-color: var(--color-grey5);
  cursor: pointer;
  width: 50px;
  height: 50px;
  border-radius: 50%;
  margin: 0 0.4rem;
  transition: all 0.4s ease-in-out;
}
.contact-container .contact-content-con .left-contact .contact-info .contact-icon a:hover {
  background-color: var(--color-secondary);
}
.contact-container .contact-content-con .left-contact .contact-info .contact-icon a:hover i {
  color: var(--color-primary);
}
.contact-container .contact-content-con .left-contact .contact-info .contact-icon a i {
  display: flex;
  justify-content: center;
  align-items: center;
  font-size: 1.3rem;
}
.contact-container .contact-content-con .right-contact {
  flex: 3;
}
.contact-container .contact-content-con .right-contact form .input-control {
  margin: 1.5rem 0;
}
.contact-container .contact-content-con .right-contact form .input-control input,
.contact-container .contact-content-con .right-contact form .input-control textarea {
  border-radius: 30px;
  background-color: var(--color-sand);
  color: var(--color-grey4);
  font-weight: inherit;
  font-size: inherit;
  font-family: inherit;
  padding: 0.8rem 1.1rem;
  outline: none;
  border: none;
  width: 100%;
  resize: none;
}
.contact-container .contact-content-con .right-contact form .input-control ::placeholder {
  color: var(--color-grey4);
}
.contact-container .contact-content-con .right-contact form .i-c-2 {
  display: flex;
}
.contact-container .contact-content-con .right-contact form .i-c-2 :last-child {
  margin-left: 1.5rem;
}
.contact-container .contact-content-con .right-contact form .main-btn__link.send {
  background-color: var(--color-sand);
  margin-left: 45%;
  color: var(--color-grey4);
  padding: 1.5rem;
  width: 10%;
  font-size: larger;
  display: flex;
  justify-content: center;
  align-items: center;
}
.contact-container .contact-content-con .right-contact form .main-btn__link.send:hover {
  transform: scale(110%);
}
.contact-container .contact-content-con .right-contact form .main-btn__link.send:hover::before {
  content: "Click to Load... my CV";
  z-index: 100;
  display: flex;
  justify-content: center;
  align-items: center;
  width: 100%;
  height: 100%;
  background-color: var(--color-sand);
  transform: translateX(0);
  transition: all 0.4s ease-in-out;
}

.btn-con__link {
  border-radius: 30px;
  color: var(--color-white);
  font-weight: 600;
  position: relative;
  display: flex;
  align-items: center;
  overflow: hidden;
  background-color: var(--color-grey5);
}
.btn-con__link:hover {
  transform: scale(150%);
}
.btn-con__link:hover__text {
  display: none;
}
.btn-con__link:hover::before {
  content: "Click to Load... my CV";
  z-index: 100;
  display: flex;
  justify-content: center;
  align-items: center;
  color: var(--color-sand);
  transform: translateX(0);
  transition: all 0.4s ease-in-out;
}

section div {
  position: relative;
}

.header-content {
  overflow: visible;
}
.header-content .right-header {
  position: relative;
  width: 100%;
  height: 100%;
}
.header-content .right-header .left-header {
  position: absolute;
  z-index: 1;
}
.header-content .right-header .left-header .image {
  border-radius: 14px;
  height: 90%;
  width: 78%;
  margin-left: 4rem;
  z-index: 2;
  display: flex;
  justify-content: center;
  align-items: center;
  transition: all 0.4s ease-in-out;
}
.header-content .right-header .left-header .image img {
  width: 70%;
  height: 70%;
  object-fit: cover;
  transition: all 0.4s ease-in-out;
  clip-path: polygon(25% 0%, 75% 0%, 100% 50%, 75% 100%, 25% 100%, 0% 50%);
}

/*About*/
.about-container_info .right-about .about-item {
  border: 1px solid var(--color-grey5);
  border-radius: 5px;
  transition: all 0.4s ease-in-out;
  box-shadow: 1px 2px 15px rgba(0, 0, 0, 0.1);
}
.about-container_info .right-about .about-item:hover {
  cursor: default;
  transform: translateY(-5px);
  border: 1px solid var(--color-secondary);
  box-shadow: 1px 4px 15px rgba(0, 0, 0, 0.32);
}
.about-container_info .right-about .about-item .abt-text .large-text {
  font-size: calc(2rem + 1vh);
  font-weight: 700;
  color: var(--color-secondary);
}
.about-container_info .right-about .about-item .abt-text .small-text {
  padding-left: 3rem;
  position: relative;
  text-transform: uppercase;
  font-size: calc(1rem + 1vh);
  color: var(--color-black);
  letter-spacing: 2px;
}
.about-container_info .right-about .about-item .abt-text .small-text::before {
  content: "";
  position: absolute;
  left: 0;
  top: 15px;
  width: 2rem;
  height: 2px;
  background-color: var(--color-grey5);
}
.about-container_info .left-about h4 {
  font-size: calc(1.5rem + 1vh);
  text-transform: uppercase;
}

/*Timeline*/
.timeline .timeline-item h5 {
  padding: 1rem 0;
  text-transform: uppercase;
  font-size: 1.3rem;
  font-weight: 600;
}
.timeline .timeline-item h5 span {
  color: var(--color-grey2);
  font-weight: 500;
  font-size: 1.2rem;
}
.timeline .timeline-item p {
  color: var(--color-grey2);
}

/*Portfolios*/
/*contact section*/
/*Indenpended components*/
.main-btn__link.send {
  background-color: var(--color-grey5);
  margin-left: 45%;
  color: var(--color-grey4);
  padding: 1.5rem;
  width: 10%;
  font-size: larger;
  display: flex;
  justify-content: center;
  align-items: center;
}
.main-btn__link.send:hover {
  transform: scale(110%);
}
.main-btn__link.send:hover::before {
  content: "Click to Load... my CV";
  z-index: 100;
  display: flex;
  justify-content: center;
  align-items: center;
  width: 100%;
  height: 100%;
  background-color: var(--color-secondary);
  transform: translateX(0);
  transition: all 0.4s ease-in-out;
}

.portfolio {
  text-align: center;
  position: relative;
}
.portfolio .bg-text {
  position: absolute;
  top: 50%;
  left: 50%;
  color: var(--color-grey5);
  transition: all 0.4s ease-in-out;
  z-index: 1;
  font-weight: 800;
  font-size: calc(1rem + 1vh);
  text-transform: uppercase;
  text-shadow: var(--color-secondary) 1px 0 10px;
}

.about-container_title h2 {
  position: relative;
  text-transform: uppercase;
  font-size: calc(2rem + 1vh);
  font-size: 700;
  z-index: 2;
}
.about-container_title h2 span {
  color: var(--color-secondary);
  z-index: 2;
  font-size: calc(2rem + 1vh);
  position: relative;
}
.about-container_title .bg-text {
  position: absolute;
  top: 50%;
  left: 50%;
  color: var(--color-grey5);
  transition: all 0.4s ease-in-out;
  z-index: 1;
  font-weight: 800;
  font-size: calc(1rem + 1vh);
  text-transform: uppercase;
  text-shadow: var(--color-secondary) 1px 0 10px;
}

/* Dark Mode Toggle */
:root {
  --color-primary: rgb(226, 195, 195);
  --color-secondary: rgb(255,182,193);
  --color-white: #FFFFFF;
  --color-black: #000;
  --color-grey0: #f8f8f8;
  --color-grey1: #dbe1e8;
  --color-grey2: #b2becd;
  --color-grey3: #6c7983;
  --color-grey4: #454e56;
  --color-grey5: #2a2e35;
  --color-grey6: #12181b;
  --color-blue: rgb(106, 125, 201);
  --color-sand: rgb(221,205,181);
}

[data-theme=light] {
  --color-primary: #FFFFFF;
  --color-secondary: pink ;
  --color-white: #6c7983;
  --color-black: #000;
  --color-grey0: #f8f8f8;
  --color-grey1: #dbe1e8;
  --color-grey2: #b2becd;
  --color-grey3: #6c7983;
  --color-grey4: #454e56;
  --color-grey5: #2a2e35;
  --color-grey6: #12181b;
  --color-blue: rgb(203, 211, 242);
  --color-sand: rgb(232, 213, 207) ;
}

body {
  font-family: "Poppins", sans-serif;
  font-size: 1.1rem;
  color: var(--color-white);
  transition: all 0.4s ease-in-out;
  width: 100%;
  height: 100vh;
  position: relative;
}

a {
  display: inline-block;
  text-decoration: none;
  color: inherit;
  font-family: inherit;
}

.portfolio-link {
  text-decoration: underline;
}

.main-content {
  display: grid;
  grid-template-areas: "headerContainer" "aboutContainer" "portfoliosContainer" "contactContainer" "theme";
  width: 100%;
  height: 100vh;
}

.sec1,
.sec2,
.sec3,
.sec4,
.sec5 {
  display: none;
}

.active {
  display: block;
  animation: scaleAnim 1s ease-in-out;
}
@keyframes scaleAnim {
  0% {
    transform: translateY(-100%) scale(0);
  }
  100% {
    transform: translateY(0) scale(1);
  }
}

.header-container {
  width: 100%;
  height: 100vh;
  display: grid;
  grid-template-columns: 0% 85% 15%;
  grid-template-areas: "invisible headerContent controlls";
}
.header-container .main-photo {
  grid-area: invisible;
}
.header-container .main-photo img {
  width: 0%;
  height: 0%;
}
.header-container .header-content {
  grid-area: headerContent;
}
.header-container .controlls {
  grid-area: controlls;
}

@media (min-width: 768px) {
  .header-container {
    width: 100%;
    height: 100vh;
    display: grid;
    grid-template-columns: 20% 65% 15%;
    grid-template-areas: "invisible headerContent controlls";
    overflow-y: hidden;
  }
  .header-container .header-content {
    grid-area: headerContent;
    background-image: none;
  }
  .header-container .main-photo {
    grid-area: invisible;
    display: flex;
    justify-content: center;
    align-items: center;
  }
  .header-container .main-photo img {
    width: 100%;
    height: 30vh;
  }
  .header-container .controlls {
    grid-area: controlls;
  }
}
@media (min-width: 1000px) {
  .header-container .main-photo img {
    height: 50vh;
  }
}
.about-container .about-container .about-container_info .right-about {
  display: flex;
  justify-content: center;
  align-items: center;
  flex-direction: column;
}
.about-container .invisible {
  grid-area: invisible;
}
.about-container .invisible img {
  width: 0%;
  height: 0%;
}
.about-container .header-content {
  grid-area: headerContent;
}
.about-container .controlls {
  grid-area: controlls;
}

@media (min-width: 769px) {
  .about-container .right-about {
    background-color: yellow;
    display: grid;
    grid-template-columns: 25% 25% 25% 25%;
    grid-template-rows: repeat(2, 300px);
    grid-template-areas: "myown myown course course" ".... learn learn ....";
  }
  .about-container .right-about .about-item {
    width: 100%;
    height: 100%;
    padding: 10%;
  }
  .about-container .right-about .myown {
    grid-area: myown;
  }
  .about-container .right-about .course {
    grid-area: course;
  }
  .about-container .right-about .learn {
    grid-area: learn;
  }
}
.portfolios {
  display: grid;
  grid-template-columns: 1fr;
  grid-gap: 2rem;
  margin-top: 3rem;
}

@media (min-width: 769px) {
  .portfolio-container .portfolios {
    display: grid;
    grid-template-columns: repeat(auto-fill, minmax(5px, 1fr) minmax(300px, 1fr));
  }
  .portfolio-container .stars-break i:nth-child(2),
.portfolio-container .stars-break i:nth-child(3) {
    display: none;
  }
}
@media (min-width: 1000px) {
  .invisible {
    justify-content: end;
  }
}
@media (max-width: 768px) {
  .about-container_info .left-about {
    padding-right: 0;
    align-self: flex-start;
  }
  .about-container_info .left-about .about-item {
    width: 90%;
    align-self: flex-start;
  }
  .about-container_info .left-about .btn-con {
    display: flex;
    justify-content: center;
    align-self: center;
  }
  .about-container_info .about-stats .stat-title {
    font-size: calc(1rem + 1vh);
  }
  .about-container_info .portfolios {
    display: grid;
    grid-template-columns: 1fr;
    padding-bottom: 6rem;
  }
  .about-container_info .blogs {
    display: grid;
    grid-template-columns: 1fr;
    padding-bottom: 6rem;
  }
  .about-container_info .theme-switch {
    display: inline-block;
    height: 34px;
    position: relative;
    width: 60px;
  }
  .about-container_info .slider::before {
    background: #fff;
    bottom: 4px;
    content: "";
    height: 26px;
    left: 4px;
    position: absolute;
    transition: 0.4s;
    width: 26px;
  }
  .about-container_info .about-container_title {
    padding-top: 4rem;
  }
  .about-container_info .about-container_title h2 span {
    font-size: 2.5rem;
  }
  .about-container_info .about-container_title h2 .bg-text {
    color: var(--color-secondary);
    font-size: 1.5rem;
    transform: translateY(-30px);
    font-weight: 400;
    text-shadow: var(--color-secondary) 1px 0 10px;
  }
  .about-container_info .controlls {
    min-height: 500px;
    justify-content: space-between;
  }
  .about-stats .stat-title {
    font-size: calc(1rem + 1vh);
  }
  .stat-title {
    font-size: calc(1rem + 1vh);
  }
}
.timeline .timeline-item .h5 {
  text-align: justify;
}

.contact-content-con {
  flex-direction: column;
}
.contact-content-con .right-contact {
  margin-left: 0;
  margin-top: 2.5rem;
}
.contact-content-con .left-contact h4 {
  font-size: 1.5rem;
}
.contact-content-con .left-contact .contact-info .contact-item {
  display: flex;
  justify-content: flex-start;
  align-items: flex-start;
  flex-direction: column;
}
.contact-content-con .left-contact .contact-info .contact-item .icon {
  font-size: calc(1rem + 0.5vh);
  color: var(--color-secondary);
}
.contact-content-con .left-contact .contact-info .contact-item p {
  align-self: center;
}

.contact-content-con .right-contact .i-ctrl-2 {
  flex-direction: column;
}

.contact-content-con .right-contact .i-ctrl-2 :last-child {
  margin-left: 0 !important;
  margin-top: 1.5rem;
}

@media (min-width: 769px) {
  .sec2 .timeline .timeline-item .tl-duration {
    padding: 0.9rem 1.2rem;
  }
  .contact-content-con {
    display: flex;
    justify-content: center;
    align-items: center;
  }
  .contact-content-con .right-contact {
    width: 80%;
    margin-left: 0;
    margin-top: 2.5rem;
  }
  .contact-content-con .left-contact {
    width: 80%;
  }
  .contact-content-con .left-contact h4 {
    font-size: 1.5rem;
    text-align: center;
  }
  .contact-content-con .left-contact .contact-info .contact-item {
    display: flex;
    align-items: center;
    flex-direction: row;
  }
  .contact-content-con .left-contact .contact-info .contact-item .icon {
    font-size: calc(1rem + 0.5vh);
    color: var(--color-secondary);
    margin-right: auto;
  }
  .contact-content-con .left-contact .contact-info .contact-item p {
    align-self: center;
  }
}
@media (min-width: 1000px) {
  .header-content .left-header .h-shape {
    display: block;
  }
  .header-content .left-header .image {
    height: 100%;
    width: 100%;
  }
  .header-content .right-header {
    grid-row: initial;
    justify-content: center;
  }
}
:root {
  --color-primary: rgb(226, 195, 195);
  --color-secondary: rgb(255,182,193);
  --color-white: #FFFFFF;
  --color-black: #000;
  --color-grey0: #f8f8f8;
  --color-grey1: #dbe1e8;
  --color-grey2: #b2becd;
  --color-grey3: #6c7983;
  --color-grey4: #454e56;
  --color-grey5: #2a2e35;
  --color-grey6: #12181b;
  --color-blue: rgb(106, 125, 201);
  --color-sand: rgb(221,205,181);
}

[data-theme=light] {
  --color-primary: #FFFFFF;
  --color-secondary: pink ;
  --color-white: #6c7983;
  --color-black: #000;
  --color-grey0: #f8f8f8;
  --color-grey1: #dbe1e8;
  --color-grey2: #b2becd;
  --color-grey3: #6c7983;
  --color-grey4: #454e56;
  --color-grey5: #2a2e35;
  --color-grey6: #12181b;
  --color-blue: rgb(203, 211, 242);
  --color-sand: rgb(232, 213, 207) ;
}

body {
  font-family: "Poppins", sans-serif;
  font-size: 1.1rem;
  color: var(--color-white);
  transition: all 0.4s ease-in-out;
  width: 100%;
  height: 100vh;
  position: relative;
}

a {
  display: inline-block;
  text-decoration: none;
  color: inherit;
  font-family: inherit;
}

.portfolio-link {
  text-decoration: underline;
}

/*# sourceMappingURL=style.cs.map */
