<template>
    <div class="projectlist-container">
        <div class="hero-section-meta medium-visible small-hidden" v-bind:style="{ 'background-image': 'url( /static/parallax-bg.png)'}"> </div>
        <div class="hero-section-text-meta medium-visible small-hidden">
            <h4 class="medium-visible">
                {{meta.Heading1}}
            </h4>
            <p class="hero-description-meta">{{meta.Heading2}}</p>

            <div class="rocket-animation-container">
                <img class="rockets"  src="/static/Rockets/Rockets.svg">
                <div class="smoke-container" > 
                <img src="/static/Rockets/rocketSmoke.svg" alt="small-smoke-1" />
                 <img src="/static/Rockets/BackShadows.svg" class="back-shadows" alt="back shadows"/>
                 <img src="/static/Rockets/FrontShadows.svg" class="front-shadows" alt="front shadows"/>
                </div>
            </div>
        </div>
        <img class="small-visible medium-hidden parallax-small" src="/static/parallax-bg.png" alt="parallax"/>
         <div class="small-visible medium-hidden text-overlay-small">
            <h4>{{meta.Heading1}}</h4>
            <p>{{meta.Heading2}}</p>

            <div class="rocket-animation-container">
                <img class="rockets"  src="/static/Rockets/Rockets.svg">
                <div class="smoke-container"> 
                <img src="/static/Rockets/rocketSmoke.svg" alt="small-smoke-1" class="small-smoke" />
                 <img src="/static/Rockets/BackShadows.svg" class="back-shadows" alt="back shadows"/>
                 <img src="/static/Rockets/FrontShadows.svg" class="front-shadows" alt="front shadows"/>
                </div>
            </div>
        </div>
  </div>

</template>
<script>
import Vue from 'vue'

export default{
name:"ProjectListMeta",
props:['meta']
}
</script>
