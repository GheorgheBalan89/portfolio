<template>
<footer class="site-footer">
   <div class="text-center heading">
      <h4>Contact me</h4>
    </div>
  <div class="grid-container">
     <div class="grid-x grid-margin-x align-center">
      <div class="cell medium-2 text-center footer-col">
          <a class="footer-icon" :href="cv" target="_blank">
            <img src="/static/footer_images/avatar/Avatar.svg" alt="cv">
            <p>CV</p>
          </a>            
      </div>
      <div class="cell medium-3  text-center footer-col">
        <a class="footer-icon" href="mailto:nerija.balan@gmail.com" >
            <img src="/static/footer_images/mail/e-mail.svg" alt="mail">
            <p>nerija.balan@gmail.com</p>
          </a>
      </div>
      <div class="cell medium-3  text-center footer-col">
           <a class="footer-icon" href="#">
            <img src="/static/footer_images/phone/phone.svg" alt="phone">
            <p>+45 42 67 10 72</p>
          </a>
      </div>
      <div class="cell medium-2  text-center footer-col">
         <a class="footer-icon" href="https://www.linkedin.com/in/nerija-butkevi%C4%8Di%C5%ABt%C4%97-balan-41176445/" target="_blank">
            <img src="/static/footer_images/linkedin/LinkedIn.svg" alt="linkedin">
            <p>LinkedIn</p>
          </a>
      </div>
       <div class="cell medium-2  text-center footer-col">
         <a class="footer-icon" href="https://github.com/nerija" target="_blank">
            <img src="/static/footer_images/git/Github.svg" alt="github">
            <p>GitHub</p>
          </a>
      </div>
    </div>
  </div>
  <div class="footer-bg"></div>
</footer>


</template>

<script>
import axios from "axios"
export default{
    name: "Footer",
    data(){
        return {
            cv:"",
            cvText:"",
        }
    },
        mounted(){
          var getcv = "/umbraco/Api/ContentApi/GetResume?websiteName=Nerija";
              axios.get(getcv).then(response => {
              this.cv = response.data.Cv;
              this.cvText = response.data.CvText;
        });
        
    }
}
</script>