<template>
<div>
   <u-animate-container>
    <u-animate name="fadeOutUp" key="nav1"  delay="0s" duration="2s" :iteration="1" :offset="0" animateClass="fadeOutUp" :begin="false"  >
      <nav class="hover-underline-menu" data-menu-underline-from-center>
        <ul v-if="navData" class="menu align-center">
            <li> <a class="underline-from-center" href="/">Home</a> </li> 
            <li v-for="navItem in navData" v-if="!navItem.IsHidden">
                <a v-if="isHovered"  :href="navItem.Url"  @mouseover ="menuHover()" class="underline-from-center"> {{ navItem.Label }} </a>
                <a v-else :href="navItem.Url"  @mouseover ="menuHover()" class="underline-from-center"> {{ navItem.Label }} </a>
            </li>
        </ul>
        </nav>
    </u-animate>
       <u-animate class="hide" name="fadeInUp"  delay="0s" duration="2s" :iteration="1" :offset="0" animateClass="fadeInUp" :begin="false"  >
       <nav class="underline-menu-reverse" data-menu-underline-from-center>
        <ul v-if="navData" class="menu align-center">
            <li> <a class="underline-from-center" href="/">Home</a> </li> 
            <li v-for="navItem in navData" v-if="!navItem.IsHidden">
                <a v-if="isHovered"  :href="navItem.Url"  @mouseover ="menuHover()" class="underline-from-center"> {{ navItem.Label }} </a>
                <a v-else :href="navItem.Url"  @mouseover ="menuHover()" class="underline-from-center"> {{ navItem.Label }} </a>
            </li>
        </ul>
        </nav>
        </u-animate>
     </u-animate-container>
</div>
</template>
<script>
import Vue from 'vue'
import axios from "axios"
import VueWow from 'vue-wow'
Vue.use(VueWow)

import {UAnimateContainer, UAnimate} from 'vue-wow'

export default{
    name: 'NavigationNerija',
    data(){
        return {
            navData: "",
            isHovered: false
        };
    },
    mounted(){
        axios.get("/umbraco/Api/ContentApi/GetNavigation/65ee23").then(response => {
            // console.log(response.data);
            this.navData = response.data;
        });
        
    },
    methods: {
        menuHover: function(){
             this.isHovered = true;
        }
    }
}
</script>