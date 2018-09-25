<template>
    <nav class="hover-underline-menu" data-menu-underline-from-center>

    <ul v-if="navData" class="menu align-center">
        <li> <a class="underline-from-center" href="/">Home</a> </li> 
        <li v-for="navItem in navData" v-if="!navItem.IsHidden">
            <a v-if="isHovered"  :href="navItem.Url"  @mouseover ="menuHover()" class="underline-from-center"> {{ navItem.Label }} </a>
            <a v-else :href="navItem.Url"  @mouseover ="menuHover()" class="underline-from-center"> {{ navItem.Label }} </a>
        </li>
     </ul>
    </nav>
</template>
<script>

import axios from "axios"

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