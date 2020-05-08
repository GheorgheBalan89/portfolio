<template>
    <div class="projectlist-container">
        <div class="hero-section-meta" v-bind:style="{ 'background-image': 'url( /static/parallax-bg.png)'}"> </div>
         <div class="hero-section-text-meta">
            <h4 class="medium-visible">
                {{meta.Heading1}}
            </h4>
            <p class="hero-description-meta">{{meta.Heading2}}</p>
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
