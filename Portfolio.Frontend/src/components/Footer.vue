<template>
<footer class="marketing-site-footer">
  <div class="grid-container">
    <div class="grid-x grid-margin-x align-center">
      <div class="cell medium-3 text-center footer-col">
         <p>  <button class="button primary" :href="cv" target="_blank">{{cvText}}</button></p>
          <p> <a href="https://www.linkedin.com/in/nerija-butkevi%C4%8Di%C5%ABt%C4%97-balan-41176445/" target="_blank"> LinkedIn</a> 
            | <a href="https://www.behance.net/nerijabalan_ux" target="_blank"> Behance</a> 
            </p>
         <p>© Nerija Butkeviciute-Balan</p>      
      </div>
    </div>
  </div>
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