<template>  
<div class="navigation-container">
    <div>
      <nav class="hover-underline-menu" data-menu-underline-from-center>
         <div class="top-bar">
            <img src="/static/Avatar.png" class="header-image" alt="logo">
        </div>
        <ul v-if="navData" class="menu align-center">
            <li v-for="navItem in navData" v-if="!navItem.IsHidden">
                <a v-if="isHovered"  :href="navItem.Url"  @mouseover ="menuHover()" class="underline-from-center"> {{ navItem.Label }} </a>
                <a v-else :href="navItem.Url"  @mouseover ="menuHover()" class="underline-from-center"> {{ navItem.Label }} </a>
            </li>
        </ul>
    </nav>    
    </div>
</div>
</template>
<script>
import Vue from 'vue'
import axios from "axios"


export default{
    name: 'NavigationNerija',
    data(){
        return {
            navData: "",
            scrollPosition: "",
            isHovered: false
        };
    },
    mounted(){
        axios.get("/umbraco/Api/ContentApi/GetNavigation/65ee23?websiteName=Nerija").then(response => {
            // console.log(response.data);
            this.navData = response.data;
        });
        
    },
    methods: {
        menuHover: function(){
             this.isHovered = true;
        },
        updateScroll: function(){
            this.scrollPosition = Number(window.scrollY);
        }
    },
    created(){
          window.addEventListener('scroll', this.updateScroll);
    },
    destroy() {
         window.removeEventListener('scroll', this.updateScroll)
    }
}
</script>