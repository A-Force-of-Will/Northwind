// Import the cucumber operators we need
import { Before, Given, Then, When } from "@cucumber/cucumber";
import { AppPage } from "../app.po";
import { element, by } from "protractor";
import { expect } from "chai";
let page: AppPage;

Before(() => {
  page = new AppPage();
});

Given("I am on the counter-two page", async () => {
  await page.navigateToCounterTwo();
});


When("I click on the increment button {int} times", async (x: number) => {
    const incrementButton = element(by.id("increment"));

    for (var i = 0; i < x; i++) {
    await incrementButton.click();
    }
});

Then("The counter should show {string}", async (x: string) => {

  expect(await element(by.id("counter")).getText()).to.equal(x);
});
