import resolve from "rollup-plugin-node-resolve";
import commonjs from "rollup-plugin-commonjs";
import babel from "rollup-plugin-babel";
import { terser } from "rollup-plugin-terser";

process.env.INCLUDE_DEPS === "true";

module.exports = {
  input: "Script/TransitionScript.js",
  output: {
    file: "artifacts/TransitionScript.js",
    format: "iife",
  },
  plugins: [
    resolve(),
    commonjs(), // so Rollup can convert dependencies to an ES module
    babel({
      runtimeHelpers: true,
      extensions: [".js", ".jsx", ".es6", ".es", ".mjs"],
      plugins: ["@babel/plugin-proposal-class-properties"],
    }),
    terser(),
  ],
};
