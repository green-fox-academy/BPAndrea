package com.xmas.sqlagain.service;

import com.xmas.sqlagain.model.Item;
import com.xmas.sqlagain.repository.ItemRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;

@Service
public class ItemServiceImpl implements ItemService {
    private ItemRepository itemRepository;

    @Autowired
    public ItemServiceImpl(ItemRepository itemRepository) {
        this.itemRepository = itemRepository;
    }

    @Override
    public List<Item> getAll() {
        return itemRepository.findAll();
    }

    @Override
    public List<Item> getActive() {
        List<Item> active = new ArrayList<>();
        active = itemRepository.findAll().stream().
                filter(item -> !item.isDone()).collect(Collectors.toList());
        return active;
    }

    @Override
    public void addItem(Item item) {
        if (item != null) {
            itemRepository.save(item);
        }
    }

    @Override
    public void deleteItemById(long id) {
        itemRepository.deleteById(id);
    }

    @Override
    public Item findById(Long id) {
        return itemRepository.findAllById(id);
    }

    @Override
    public Item updateItem(Item item) {
        return itemRepository.save(item);
    }

    @Override
    public List<Item> findByNameOrDescription(String keyword) {
        return itemRepository.findAllByNameContainingOrDescriptionContaining(keyword, keyword);
    }


}
