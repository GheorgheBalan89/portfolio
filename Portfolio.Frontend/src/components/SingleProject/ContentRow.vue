<template>   
<div>   
             
             <!-- <div v-if="detail.VideoUrl !=''  && detail.VideoUrl != null" class="project-details-section-img large-order-1 medium-order-1">
                <iframe :src="detail.VideoUrl" width="952" height="450" webkitallowfullscreen mozallowfullscreen allowfullscreen> </iframe>
            </div> -->
        
            <div v-if="rows !=null && row != null" :key="row.BigHeading" v-for="row in rows"  class="row content-row">
                <h2 v-if="row.BigHeading != null">{{row.BigHeading}}</h2>
                <div v-if="row.Icon != null" class="grid-x">
                    <div class="cell medium-2 icon-container">
                         <img v-if="row.Icon != null" class="icon" :src="row.Icon" :alt="row.BigHeading || row.SmallHeading">
                       
                    </div>
                    <div v-if="row.TextColumnLeft != null" class="cell medium-5 text">
                        <p>
                          {{row.TextColumnLeft}}
                        </p>
                    </div>
                    <div v-if="row.TextColumnRight" class="cell medium-5 text">
                        <p>
                          {{row.TextColumnRight}}
                        </p>
                    </div>
                </div>
               <div v-else-if="row.Icon == null && row.SmallHeading != null" class="grid-x layout-2">
                   <div class="cell medium-2 icon-container">
                         <h3 class="small-heading" v-if="row.SmallHeading != null">{{row.SmallHeading}}</h3>
                   </div>
                    <div v-if="row.TextColumnLeft != null" class="cell medium-5 text-layout-2">
                        <p>
                          {{row.TextColumnLeft}}
                        </p>
                    </div>
                    <div v-if="row.TextColumnRight" class="cell medium-5 text-layout-2">
                        <p>
                          {{row.TextColumnRight}}
                        </p>
                    </div>
              </div>
                <div class="grid-x">
                    <div class="cell medium-12 main-image-container">
                        <img class="main-image" :src="row.Image" :alt="row.BigHeading || row.SmallHeading">
                    </div>
                </div>
            </div>  
</div>
</template>

<script>
import axios from "axios"

export default{  
    name : "ContentRow",
    props: ["rows"],
    methods:{
         track: function(){
            var pathname =  window.location.origin + window.location.pathname;
           page(pathname);
        }
    }
}
</script>