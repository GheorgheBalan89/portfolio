<template>   
<div>   
            <!-- <div v-if="row != null && row.Details != null" class="large-visible">
                  <div  v-for="(detail, projId) in row.Details" v-if="projId % 2 == 0"  :key="projId">
                    <div  class="project-details-section">
                        <div class="project-details-section-block small-order-2 medium-order-1">
                            <h3 class="project-details-section-block-header">{{detail.Heading}}</h3>
                            <div class="details-richtext text-padding-right" v-html="detail.RichText"></div>
                        </div>

                        <div v-if="detail.MediaItem" class="project-details-section-img large-order-1 medium-order-2">
                            <img :src="detail.MediaItem" alt="" />
                        </div>
                        <div v-if="detail.VideoUrl !=''  && detail.VideoUrl != null" class="project-details-section-img large-order-1 medium-order-1">
                                <iframe :src="detail.VideoUrl" width="952" height="450" webkitallowfullscreen mozallowfullscreen allowfullscreen> </iframe>
                         </div>
                    </div>
                </div>
                <div v-else :key="projId">
                    <div class="project-details-section">
                            <div v-if="detail.MediaItem" class="project-details-section-img small-order-1 medium-order-1">
                                <img :src="detail.MediaItem" alt="" />
                            </div>
                            <div v-if="detail.VideoUrl !='' && detail.VideoUrl != null" class="project-details-section-img large-order-1 medium-order-1">
                                <iframe :src="detail.VideoUrl" width="952" height="450" webkitallowfullscreen mozallowfullscreen allowfullscreen></iframe>
                            </div>
                            <div class="project-details-section-block large-order-2 medium-order-2">
                                <h3 class="project-details-section-block-header heading-padding-left" >{{detail.Heading}}</h3>
                                <div class="details-richtext text-padding-left" v-html="detail.RichText"></div>
                            </div>
                        </div>
                </div>
                &nbsp;
                &nbsp;
            </div> -->
            
        
            <div v-if="rows !=null && row != null" :key="row.BigHeading" v-for="row in rows"  class="row content-row">
                <h2>{{row.BigHeading}}</h2>
                <div class="grid-x">
                    <div class="cell medium-2 icon-container">
                         <img v-if="row.Icon != null" class="icon" :src="row.Icon" :alt="row.BigHeading || row.SmallHeading">
                         <h3 class="small-heading" v-if="row.SmallHeading != null">{{row.SmallHeading}}</h3>
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
                <div class="grid-x">
                    <div class="cell medium-12">
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