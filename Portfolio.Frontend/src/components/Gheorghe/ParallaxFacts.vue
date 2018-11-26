<template>
<section>
    <div class="grid-x parallax-container" >
        <img src="../../assets/parallax2.jpg" />
        <div class="parallax-fact-container cell large-12">
            <div class="grid-x ">
                <div v-for="n in 4" class="cell medium-3 text-center">
                   <font-awesome-icon icon="users-cog"  class="fact-icon"/>
                    <p class="fact-title">Title</p>
                    <p class="fact-subtitle">Subtitle</p>
                </div>
            </div>
        </div>
   </div>

   <!-- <div v-for="x in 20">
        "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est,
   </div> -->

</section>
</template>
<script>
import Vue from 'vue'

export default{
    name: "ParallaxFacts",
    
}
</script>