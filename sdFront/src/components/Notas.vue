<template>
  <app>
    <div class="container-fluid">
      <div class="row">
        <div class="offset-md-2 offset-lg-2 col-md-8 col-lg-8">
          <input type="number" class="form-control" v-model="n1" />
        </div>
      </div>
      <div class="row">
        <div class="offset-md-2 offset-lg-2 col-md-8 col-lg-8">
          <input class="form-control" v-model="n2" />
        </div>
      </div>
      <div class="row">
        <div class="offset-md-2 offset-lg-2 col-md-8 col-lg-8">
          <button class="btn" @click="post">Calcular</button>
        </div>
      </div>
      <p v-if="situacao.length">{{situacao}}</p>
    </div>
  </app>
</template>

<script>
import appMenu from './Menu.vue';
export default {
  components: {
    app: appMenu,
  },
  data () {
    return {
      n1: 0,
      n2: 0,
      situacao: '',
    }
  },
  methods: {
    post() {
      this.$http.post('http://localhost:5000/api/notas', [this.n1, this.n2]).then(
        success => {
          this.situacao = success.bodyText;
          // console.log(success);
        },
        err => {
          // console.log(err);
        }
      )
    }
  }
}
</script>

<style scoped>

</style>
